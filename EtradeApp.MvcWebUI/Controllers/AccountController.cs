using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EtradeApp.Business.Abstract;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.Entities;
using EtradeApp.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EtradeApp.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        private IOrderService _orderService;
        private ICartService _cartService;

        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signInManager, IOrderService orderService, ICartService cartService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _orderService = orderService;
            _cartService = cartService;
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterUser(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var userExists = _userManager.Users.FirstOrDefault(u => u.Email == registerViewModel.Email && u.UserName == registerViewModel.UserName);
                if (userExists != null)
                {
                    TempData.Add("message", "Bu bilgiler ile daha önce kayıt olunmuştur..");
                    return View("RegisterUser");
                }
                CustomIdentityUser user = new CustomIdentityUser
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    PhoneNumber = registerViewModel.Phone,
                };

                IdentityResult result = _userManager.CreateAsync(user, registerViewModel.Password).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("User").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "User"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Kullanıcı eklenemedi");
                            return View(registerViewModel);
                        }
                    }
                    _userManager.AddToRoleAsync(user, "User").Wait();
                    TempData.Add("message", "Başarılı bir şekilde kayıt oldunuz.");
                    return View("RegisterUser");
                }
            }
            return View();
        }


        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginUser(LoginViewModel loginViewModel, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.FirstOrDefault(u => u.UserName == loginViewModel.UserName);

                if (user == null)
                {

                    TempData.Add("message", "Kullanıcı bulunamadı.");
                    return View();
                }

                var result = _signInManager.PasswordSignInAsync(loginViewModel.UserName,
                    loginViewModel.Password, loginViewModel.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    TempData.Add("message", "Giriş başarılı.");

                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }

                TempData.Add("message", "Giriş başarısız.");
                ModelState.AddModelError("", "Giriş başarısız!");

            }
            return View(loginViewModel);
        }


        public IActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult MyOrders()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);

            var model = new OrderListViewModel
            {
                Orders = _orderService.GetOrdersByUserId(user.Value)
            };

            return View(model);
        }

        public IActionResult MyOrderDetail(int orderId)
        {

            var model = new OrderLinesViewModel
            {
                OrderLines = _orderService.GetOLinesByOrderId(orderId)
            };

            return View(model);
        }

        public IActionResult ShippingAdress(int shippingId)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = _cartService.GetAdress(user.Value)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ShippingAdress(ShippingDetail shippingDetail)
        {
            if (ModelState.IsValid)
            {
                shippingDetail.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                _cartService.UpdateShipping(shippingDetail);
                TempData.Add("message", "Başarılı bir şekilde güncellendi..");
            }

            return View();
        }

        public IActionResult AccountSettings()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var Account = _userManager.Users.FirstOrDefault(u => u.Id == userId);

            var model = new AccountSettingsViewModel
            {
                Id = userId,
                Email = Account.Email,
                Phone = Account.PhoneNumber,
                UserName = Account.UserName
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AccountSettings(AccountSettingsViewModel accountSettingsViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.FirstOrDefault(u=> u.Id==accountSettingsViewModel.Id);
                user.Email = accountSettingsViewModel.Email;
                user.PhoneNumber = accountSettingsViewModel.Phone;
                user.UserName = accountSettingsViewModel.UserName;
                
                IdentityResult result = _userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    TempData.Add("message", "Bilgiler güncellendi..");
                }

            }

            return View();
        }

    }
}