﻿using EtradeApp.MvcWebUI.Models;
using EtradeApp.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.ViewComponents
{
    public class ShippingCartSummaryViewComponent : ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public ShippingCartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);

        }
    }
}