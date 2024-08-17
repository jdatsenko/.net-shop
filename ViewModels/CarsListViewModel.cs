using CarShop.Models;


namespace CarShop.ViewModels

{
    public class CarsListViewModel
    {

        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
