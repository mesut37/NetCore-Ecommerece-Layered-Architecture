using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
    public class ShippingDetail:IEntity
    {
        [Key]
        public int ShippingId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public string Email { get; set; }
       
        public string City { get; set; }
        
        public string Adress { get; set; }
      
        public string Phone { get; set; }

        public string UserId { get; set; }

        public Order Order { get; set; }
    }
}
