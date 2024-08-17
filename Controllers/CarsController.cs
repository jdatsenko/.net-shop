using CarShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }

}
