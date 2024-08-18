using CarShop.Models;

namespace CarShop.Interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }

        Car GetObjectCar(int carId);
    }
}
