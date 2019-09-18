using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business.Abstract
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        List<Order> GetOrdersByUserId(string UserId);
        List<OrderLine> GetOLinesByOrderId(int orderId);
    }
}
