using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public class EfCarDal:EfEntityRepositoryBase<Car,Carcontext>,ICarDal
    {
    }
}
