using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental = new Rental();            
            //rental.CarId = 3;
            //rental.CustomerId = 3;
            //rental.RentDate = System.DateTime.Today;           
            //rentalManager.Add(rental);
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental();

            rental.CarId = 6;
            rental.CustomerId = 1;
            rental.RentDate = System.DateTime.Today;
            rental.ReturnDate = null;
            rentalManager.Rent(rental);






            // RentalUpdate();
            // CustomerAdded();
            // UserAdded();
            //AddedCar();
            // CarGetAll();
        }

        private static void RentalUpdate()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental()
            {
                Id = 1,
                CarId = 1,
                RentDate = System.DateTime.Today,
                CustomerId = 5
            };

            rentalManager.Update(rental);
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();

            customer.UserId = 5;
            customer.CompanyName = "Eoztrk";

            customerManager.Add(customer);
        }

        private static void UserAdded()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user = new User();
            user.FirstName = "ece";
            user.LastName = "öztürk";
            user.Email = "ece@mail.com";
            user.Password = "1234as";

            userManager.Add(user);
        }

        private static void AddedCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car();
            car1.BrandId = 1;
            car1.ColorId = 6;
            car1.DailyPrice = 231;
            car1.ModelYear = 2021;
            car1.Description = "Deneme5";
            carManager.Add(car1);
        }

        //private static void CarGetAll()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.);

        //    }


        //}
    } 
}
