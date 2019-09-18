using EtradeApp.Core.DataAccess;
using EtradeApp.DataAccess.Concrete.EntitiyFramework;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EtradeApp.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
      

        List<OrderLine> GetOLinesByOrderId(Expression<Func<OrderLine, bool>> filter = null);

    }
}
