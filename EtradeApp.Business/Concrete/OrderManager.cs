using EtradeApp.Business.Abstract;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void AddOrder(Order order)
        {
            _orderDal.Add(order);
        }

        public List<Order> GetOrdersByUserId(string UserId)
        {
           return _orderDal.GetList(o => o.UserId == UserId);
        }

        public List<OrderLine> GetOLinesByOrderId(int orderId)
        {
            return _orderDal.GetOLinesByOrderId(o => o.OrderId == orderId);
        }
    }
}
