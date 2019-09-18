using System;
using System.Collections.Generic;
using System.Text;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;

namespace EtradeApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }



        public void Add(Product product)
        {
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(m=> m.CategoryId== categoryId || categoryId == 0);
        }
        public List<Product> GetProductandCategories()
        {
            return _productDal.GetProductandCategories();
        }
        
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
       
    }
}
