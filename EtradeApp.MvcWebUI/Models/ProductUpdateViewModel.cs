using EtradeApp.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EtradeApp.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public List<IFormFile> File { get; set; }
        public List<Photo> Photos { get; set; }
    }
}