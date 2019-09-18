using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Models
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<Photo> Photos { get; set; }
        public string PhotoUrl { get; set; }
        public List<Category> Categories { get; set; }
    }
}
