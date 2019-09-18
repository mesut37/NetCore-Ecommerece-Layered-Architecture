using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int cateoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
        List<Product> GetProductandCategories();
       
    }
}
