using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//BrandTest();

CarTest();

//ColorTest();



static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.CarDetails())
    {
        Console.WriteLine("Marka ismi : " + car.BrandName + "Renk İsmi : " + car.ColorName + "Günlük fiyatı : " + car.DailyPrice + "Açıklama : " + car.Description);

    }
}

static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    colorManager.Add(new Color { ColorName = "S" });
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    brandManager.Add(new Brand { BrandName = "B" });
}