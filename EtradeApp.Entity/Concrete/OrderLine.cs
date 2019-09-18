using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
   public class OrderLine:IEntity
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
      

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public  Product Product { get; set; }
    }
}
