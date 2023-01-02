using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

BrandManager brandManager = new BrandManager(new EfBrandDal());
//brandManager.Add(new Brand { BrandName = "B" });


CarManager carManager = new CarManager(new EfCarDal());
//carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 0, ModelYear = 2010, Description = "Benzin" });
carManager.Update(new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 400, ModelYear = 2017, Description = "Benzin" });

ColorManager colorManager = new ColorManager(new EfColorDal());
//colorManager.Add(new Color { ColorName = "S" });


