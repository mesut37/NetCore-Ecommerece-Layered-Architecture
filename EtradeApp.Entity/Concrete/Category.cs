using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
   public class Category:IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Sequance { get; set; }
        public bool Status { get; set; }
        public string ParentId { get; set; }
        

        public List<Product> Products { get; set; }

    }
}
