using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "araba", ModelYear = 2023},
            new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 230, Description = "araba2", ModelYear = 2022},
            new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 120, Description = "araba3", ModelYear = 2021},
            new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 150, Description = "araba4", ModelYear = 2018},
            new Car{Id = 5, BrandId = 4, ColorId = 4, DailyPrice = 1000, Description = "araba5", ModelYear = 2023},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public Car GetById(int Id)
        {
            return _cars.FirstOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;  
        }
    }
}
