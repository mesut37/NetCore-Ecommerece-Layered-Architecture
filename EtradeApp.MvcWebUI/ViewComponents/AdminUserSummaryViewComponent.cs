using EtradeApp.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.ViewComponents
{
    public class AdminUserSummaryViewComponent: ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            AdminUserDetailView model = new AdminUserDetailView
            {
                UserName = HttpContext.User.Identity.Name
            };

            return View(model);
        }
    }
}
