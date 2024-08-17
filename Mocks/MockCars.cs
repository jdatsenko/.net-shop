using CarShop.Interfaces;
using CarShop.Models;

namespace Shop.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();


        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla Model S", ShortDescription = "Fast car", LongDescription = "Beautiful, fast and very quiet car from Tesla", Image = "/img/tesla.jpg", Price = 45000, IsFavorite = true, Available = true, Category = _categoryCars.AllCategories.First() },
                    new Car { Name = "Ford Fiesta", ShortDescription = "Quiet and peaceful", LongDescription = "A comfortable car for city driving", Image = "/img/fiesta.jpg", Price = 11000, IsFavorite = false, Available = true, Category = _categoryCars.AllCategories.Last() },
                    new Car { Name = "BMW M3", ShortDescription = "Bold and stylish", LongDescription = "A stylish and comfortable car for city driving", Image = "/img/m3.jpg", Price = 65000, IsFavorite = true, Available = true, Category = _categoryCars.AllCategories.Last() },
                    new Car { Name = "Mercedes C class", ShortDescription = "Luxury and comfort", LongDescription = "A comfortable car for city driving", Image = "/img/mercedes.jpg", Price = 40000, IsFavorite = false, Available = false, Category = _categoryCars.AllCategories.Last() },
                    new Car { Name = "Nissan Leaf", ShortDescription = "Economic and quiet", LongDescription = "A comfortable car for city driving", Image = "/img/nissan.jpg", Price = 14000, IsFavorite = true, Available = true, Category = _categoryCars.AllCategories.First() }
                };
            }
            
        }


        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
    //ty nefor
}
