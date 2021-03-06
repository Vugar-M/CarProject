using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        void Add(Brand brand);
        void Delete(Brand brand);
        void update(Brand brand);
        List<Brand> GetAll();
        Brand GetById(int Id);
    }
}
