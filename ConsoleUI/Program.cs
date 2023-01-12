using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


RentalAdded();


static void RentalAdded()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());

    
    Rental rental = new Rental();
    rental.CarId = 1;
    rental.CustomerId = 1;
    rental.RentDate = DateTime.Now;
    rental.ReturnDate = DateTime.Now.AddDays(1);


    var result = rentalManager.Add(rental);
    Console.WriteLine(result.Message);
    
}