using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır");
            }
            else
            {
                _brandDal.Add(brand);
            }
            
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetByBrandId(int brandid)
        {
            return _brandDal.GetAll(b => b.Id == brandid);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
