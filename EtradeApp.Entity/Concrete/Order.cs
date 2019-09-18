using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
    public class Order:IEntity
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
            ShippingDetail = new ShippingDetail();
        }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }
        public int ShippingId { get; set; }
        public string UserId { get; set; }

        public ShippingDetail ShippingDetail { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}
