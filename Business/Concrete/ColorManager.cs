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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length<2)
            {
                throw new Exception("Renk ismi minimum 2 karakter olmalıdır");
            }
            else
            {
                _colorDal.Add(color);

            }
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int colorId)
        {
            return _colorDal.GetAll(c => c.Id == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
