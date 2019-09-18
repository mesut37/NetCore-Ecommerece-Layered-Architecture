using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> categories { get; internal set; }
    }
}
