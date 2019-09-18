using EtradeApp.Core.DataAccess.EntityFramewok;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EtradeApp.DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : EfEntityRespositoryBase<Product, EtradeContext>, IProductDal
    {
        public List<Product> GetProductandCategories(Expression<Func<Product, bool>> filter = null)
        {
            using (var context = new EtradeContext())
            {
                return filter == null
                    ? context.Products.Include(c => c.Category).ToList()
                    : context.Products.Include(c => c.Category).Where(filter).ToList();
            }
        }

       

        public void AddPhoto(Photo photo)
        {
            using (var context = new EtradeContext())
            {
                var addedEntity = context.Entry(photo);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public List<Photo> GetPhotosofProduct(Expression<Func<Photo, bool>> filter = null)
        {
            using (var context = new EtradeContext())
            {
                return filter == null
                    ? context.Photos.ToList()
                    : context.Photos.Where(filter).ToList();
            }
        }
    }
}
