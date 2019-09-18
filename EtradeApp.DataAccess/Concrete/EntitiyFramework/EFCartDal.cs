using EtradeApp.Core.DataAccess.EntityFramewok;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.DataAccess.Concrete.EntitiyFramework
{
   public class EFCartDal: EfEntityRespositoryBase<ShippingDetail, EtradeContext>, ICartDal
    {
    }
}
