using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class CarRepository
    {
        public string AddCar(Car car)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var carItem = context.Cars.FirstOrDefault(x => x.CarNumber == car.CarNumber);
                if (carItem != null)
                {
                    carItem.Mark = car.Mark;
                }
                else
                {
                    context.Cars.Add(car);
                }
                context.SaveChanges();
            }
            return car.CarNumber;
        }
    }
}
