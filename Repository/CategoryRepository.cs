using CarShop.Interfaces;
using CarShop.Models;	
using Microsoft.EntityFrameworkCore;


namespace CarShop.Repository
{
	public class CategoryRepository : ICarsCategory { 
		private readonly AppDBContent appDBContent;
		public CategoryRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}
		public IEnumerable<Category> AllCategories => appDBContent.Category;
	}
}

