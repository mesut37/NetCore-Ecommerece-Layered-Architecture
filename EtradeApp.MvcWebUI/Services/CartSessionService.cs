using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtradeApp.MvcWebUI.Services
{
    public class CartSessionService:ICartSessionService
    {
       
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Cart GetCart()
        {
            var cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cart;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
