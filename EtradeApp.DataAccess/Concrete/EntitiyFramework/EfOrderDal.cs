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
    public class EfOrderDal : EfEntityRespositoryBase<Order, EtradeContext>, IOrderDal
    {
        public List<OrderLine> GetOLinesByOrderId(Expression<Func<OrderLine, bool>> filter = null)
        {
            using (var context = new EtradeContext())
            {
                return filter == null
                    ? context.OrderLines.Include(p=> p.Product).ToList()
                    : context.OrderLines.Include(p => p.Product).Where(filter).ToList();
            }
        }
    }
}
