

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

RentalManager rentalManager = new RentalManager(new EfRentalDal());
//rentalManager.Add(new Entities.Concrete.Rental { CustomerId = 1004, CarId = 4006, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(2) });
