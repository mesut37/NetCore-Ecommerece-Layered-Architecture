using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EtradeApp.Entities.Concrete
{

    public class Product : IEntity
    {

        public Product()
        {
            Category = new Category();
            Photos = new List<Photo>();
        }

        public int ProductId { get; set; }


        public string ProductName { get; set; }


        public int CategoryId { get; set; }


        public decimal UnitPrice { get; set; }


        public int UnitsInStock { get; set; }


        public int Sequance { get; set; }


        public bool Status { get; set; }

        public string Details { get; set; }

        public bool IsMain { get; set; }



        public Category Category { get; set; }
        public List<Photo> Photos { get; set; }

    }
}
