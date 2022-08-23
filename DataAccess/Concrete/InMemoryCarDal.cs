using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car { Id = 1, BrandId = 1 , ColorId = 1 , DailyPrice = 10000, ModelYear = 2005, Description = "mavi"},
                                    new Car { Id = 2, BrandId = 2 , ColorId = 12 , DailyPrice = 250000, ModelYear = 2022, Description = "sarı"},
                                    new Car { Id = 3, BrandId = 3 , ColorId = 3 , DailyPrice = 100000, ModelYear = 2008, Description = "kırmızı"},
                                    new Car { Id = 4, BrandId = 4 , ColorId = 4 , DailyPrice = 75000, ModelYear = 2011, Description = "lacivert"},
                                    new Car { Id = 5, BrandId = 5 , ColorId = 5 , DailyPrice = 30000, ModelYear = 2007, Description = "yeşil"},
                                   };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
