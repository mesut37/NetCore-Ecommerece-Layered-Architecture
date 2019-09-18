using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business.Abstract
{
    public interface ICartService
    {
        void AddtoCart(Cart cart, Product product,int quantity,string PhotoUrl);
        void RemoveFromCart(Cart cart, int productId);
        void ClearCartLine(Cart cart);
        List<CartLine> List(Cart cart);
        ShippingDetail GetAdress(string userId);
        void UpdateShipping(ShippingDetail shippingDetail);
    }
}
