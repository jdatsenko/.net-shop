using CarShop.Interfaces;
using CarShop.Models;	
using Microsoft.EntityFrameworkCore;

namespace CarShop.Repository
{
	public class CarRepository : IAllCars
	{
		private readonly AppDBContent appDBContent;

		public CarRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}

		public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

		public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.IsFavorite).Include(c => c.Category);

		public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
	}
}

