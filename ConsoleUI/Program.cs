using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car { BrandId = 7, ColorId = 3, DailyPrice = 150235, Description = "haki turkuaz", Id = 8, ModelYear = 1993 };

            carManager.Add(car1);
            foreach (var car in carManager.GetAll())
            {
                if (car.Description == "haki turkuaz")
                {
                    Console.WriteLine(car.DailyPrice);
                }
            }
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
           


        }
    }
}
