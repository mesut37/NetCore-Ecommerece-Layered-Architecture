using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EtradeApp.Business;
using EtradeApp.Business.Abstract;
using EtradeApp.DataAccess.Concrete.EntitiyFramework;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.ExtensionMethods;
using EtradeApp.MvcWebUI.Models;
using EtradeApp.MvcWebUI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtradeApp.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private IProductService _productService;
        private IPhotoService _photoService;
        private ICartSessionService _cartSessionService;
        private IOrderService _orderService;

        public CartController(ICartService cartService, IProductService productService, ICartSessionService cartSessionService, IPhotoService photoService, IOrderService orderService)
        {
            _cartService = cartService;
            _productService = productService;
            _photoService = photoService;
            _cartSessionService = cartSessionService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            return View(_cartSessionService.GetCart());
        }


        public ActionResult AddToCart(int productId, int quantity = 1)
        {
            var product = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            var photos = _photoService.GetPhotosofProduct(productId);

            string photoUrl = ""; photoUrl = (photos.Count > 0) ? photos.FirstOrDefault().PhotoUrl : "nophoto.jpg";

            _cartService.AddtoCart(cart, product, quantity, photoUrl);


            _cartSessionService.SetCart(cart);

            TempData.Add("message", "Eklendi");

            return RedirectToAction("List", "Cart");
        }


        public ActionResult List()
        {
            if (_cartSessionService.GetCart().CartLines.Count <= 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new CartListViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();

            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", "Kayıt Silindi");
            return RedirectToAction("List");

        }

        [Authorize]
        public ActionResult ShippingDetails()
        {
            var cart = _cartSessionService.GetCart();
            if (cart.CartLines.Count <= 0)
            {
                return RedirectToAction("Index", "Product");
            }
            var userId = User.FindFirst(ClaimTypes.NameIdentifier);

            var ShippingAdress = _cartService.GetAdress(userId.Value);

            var model = new ShippingDetailsViewModel
            {
               ShippingDetail= ShippingAdress
            };


            return View(model);
        }

        public ActionResult WithOutShipping()
        {
            return View("ShippingDetails");
        }

        [HttpPost]
        public ActionResult ShippingDetails(ShippingDetail shippingDetail)
        {
            if (ModelState.IsValid)
            {
                var cart = _cartSessionService.GetCart();
                if (_cartService.List(cart).Count <= 0)
                {
                    return RedirectToAction("Index", "Product");
                }
                if (User.Identity.IsAuthenticated)
                {
                    var user = User.FindFirst(ClaimTypes.NameIdentifier);
                    shippingDetail.UserId = user.Value;

                    shippingDetail.ShippingId = _cartService.GetAdress(user.Value).ShippingId;
                }
                
                
              
                SaveOrder(cart, shippingDetail);
                TempData.Add("message", "Başarılı");
                return View("Completed");

            }

            return RedirectToAction("ShippingDetails");
        }

        private void SaveOrder(Cart cart, ShippingDetail entity)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.Total;
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.ShippingDetail = entity;
            order.ShippingDetail.UserId = !User.Identity.IsAuthenticated ? "0" : entity.UserId;
            order.UserId = entity.UserId;


            var orderLine = new OrderLine();
            orderLine.Order = order;

            order.OrderLines = new List<OrderLine>();

            foreach (var cartLine in cart.CartLines)
            {
                order.OrderLines.Add(new OrderLine() { Price = Convert.ToInt32(cartLine.Product.UnitPrice) * cartLine.Quantity, Quantity = cartLine.Quantity, ProductId = cartLine.Product.ProductId });
            }

            _orderService.AddOrder(order);
            _cartService.ClearCartLine(cart);
            _cartSessionService.SetCart(cart);

        }

        public ActionResult CartSummaryDelete(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);

            return Json(new { result = 1, message = "Başarılı." });
        }
    }
}
