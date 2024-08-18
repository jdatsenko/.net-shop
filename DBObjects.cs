using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop
{
	public class DBObjects
	{
		public static void Initial(AppDBContent content)
		{
			// Update or add Categories
			foreach (var category in Categories)
			{
				var existingCategory = content.Category.FirstOrDefault(c => c.CategoryName == category.Value.CategoryName);
				if (existingCategory == null)
				{
					content.Category.Add(category.Value);
				}
				else
				{
					// Update existing category details
					existingCategory.Description = category.Value.Description;
					content.Category.Update(existingCategory);
				}
			}

			// Update or add Cars
			var carsToSeed = new List<Car>
			{
				new Car
				{
					Name = "Tesla Model S",
					ShortDescription = "Fast and silent car",
					LongDescription = "Tesla Model S is a fully electric car",
					Image = "/img/tesla.jpg",
					Price = 45000,
					IsFavorite = true,
					Available = true,
					Category = Categories["Electric cars"]
				},

				new Car
				{
					Name = "Ford Fiesta",
					ShortDescription = "Quiet and economical car",
					LongDescription = "Ford Fiesta is a car with an internal combustion engine",
					Image = "/img/ford.jpg",
					Price = 11000,
					IsFavorite = false,
					Available = true,
					Category = Categories["Classic cars"]
				},

				new Car
				{
					Name = "BMW M3",
					ShortDescription = "Fast and stylish car",
					LongDescription = "BMW M3 is a car with an internal combustion engine",
					Image = "/img/bmw.jpg",
					Price = 65000,
					IsFavorite = true,
					Available = true,
					Category = Categories["Classic cars"]
				},

				new Car
				{
					Name = "Mercedes C class",
					ShortDescription = "Comfortable and stylish car",
					LongDescription = "Mercedes C class is a car with an internal combustion engine",
					Image = "/img/merc.jpg",
					Price = 40000,
					IsFavorite = false,
					Available = false,
					Category = Categories["Classic cars"]
				},

				new Car
				{
					Name = "Nissan Leaf",
					ShortDescription = "Economical and quiet car",
					LongDescription = "Nissan Leaf is a fully electric car",
					Image = "/img/nissan.jpg",
					Price = 14000,
					IsFavorite = true,
					Available = true,
					Category = Categories["Electric cars"]
				}
			};

			foreach (var car in carsToSeed)
			{
				var existingCar = content.Car.FirstOrDefault(c => c.Name == car.Name);
				if (existingCar == null)
				{
					content.Car.Add(car);
				}
				else
				{
					// Update existing car details
					existingCar.ShortDescription = car.ShortDescription;
					existingCar.LongDescription = car.LongDescription;
					existingCar.Image = car.Image;
					existingCar.Price = car.Price;
					existingCar.IsFavorite = car.IsFavorite;
					existingCar.Available = car.Available;
					existingCar.Category = car.Category;

					content.Car.Update(existingCar);
				}
			}

			content.SaveChanges();
		}

		private static Dictionary<string, Category> category;

		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (category == null)
				{
					var list = new Category[]
					{
						new Category { CategoryName = "Electric cars", Description = "Modern and silent cars" },
						new Category { CategoryName = "Classic cars", Description = "Cars with internal combustion engines" }
					};

					category = new Dictionary<string, Category>();

					foreach (Category el in list)
					{
						category.Add(el.CategoryName, el);
					}
				}

				return category;
			}
		}
	}
}
