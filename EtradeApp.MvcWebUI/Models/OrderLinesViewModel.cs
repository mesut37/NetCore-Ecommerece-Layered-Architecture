﻿using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Models
{
    public class OrderLinesViewModel
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}
