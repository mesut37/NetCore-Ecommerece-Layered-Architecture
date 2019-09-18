using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Models
{
    public class CategoryAddViewModel
    {
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
