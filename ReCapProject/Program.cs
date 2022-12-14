using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.Id);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
            }
        }
    }
}
