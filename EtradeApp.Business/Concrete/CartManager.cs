using EtradeApp.Business.Abstract;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtradeApp.Business.Concrete
{
   public class CartManager : ICartService
    {
        private ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void AddtoCart(Cart cart, Product product,int quantity,string PhotoUrl)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                cartLine.PhotoUrl = PhotoUrl;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = quantity ,PhotoUrl=PhotoUrl});
        }


        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }

        public ShippingDetail GetAdress(string userId)
        {
            return _cartDal.Get(c => c.UserId == userId);
        }

        public void ClearCartLine(Cart cart)
        {
            cart.CartLines.Clear();
        }

        public void UpdateShipping(ShippingDetail shippingDetail)
        {
            _cartDal.Update(shippingDetail);
        }
    }
}
