using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Models
{
    public class OrderListViewModel
    {
        public List<Order> Orders { get; set; }
    }
}
