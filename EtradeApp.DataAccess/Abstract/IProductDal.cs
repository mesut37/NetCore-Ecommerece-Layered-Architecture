using EtradeApp.Core.DataAccess;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EtradeApp.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetProductandCategories(Expression<Func<Product, bool>> filter = null);


    }
}
