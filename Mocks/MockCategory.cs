using CarShop.Interfaces;
using CarShop.Models;
using System.Globalization;

namespace CarShop.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Electro Cars", Description = "Modern type of transport" },
                    new Category { CategoryName = "Classic Cars", Description = "Cars with internal combustion engine" }
                };
            }
        }
    }
}
//Dmytro nefor