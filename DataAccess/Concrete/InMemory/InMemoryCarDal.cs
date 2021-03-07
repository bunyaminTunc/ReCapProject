using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;
        public InMemoryCarDal()
        {
            _carList = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = 2020, Description = "OPEL" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 1200, ModelYear = 2020, Description = "BMW" },
                new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 2000, ModelYear = 2021, Description = "FIAT" },
                new Car { Id = 4, BrandId = 2, ColorId = 4, DailyPrice = 2299, ModelYear = 2021, Description = "HYUNDAI" }

            };

        }
        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(c => c.Id == car.Id);
            _carList.Remove(carToDelete);



        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetById(int id)
        {
            return _carList.Where(c => c.Id == id).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
