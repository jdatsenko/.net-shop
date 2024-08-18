using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;
using CarShop.Interfaces;
using CarShop.Repository;

namespace CarShop
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Get connection string from configuration
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

			// Add DbContext with SQL Server provider
			builder.Services.AddDbContext<AppDBContent>(options =>
				options.UseSqlServer(connectionString));	


			builder.Services.AddControllersWithViews();
			builder.Services.AddMvc();

			builder.Services.AddTransient<IAllCars, CarRepository>();
			builder.Services.AddTransient<ICarsCategory, CategoryRepository>();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseStatusCodePages();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();


			using (var scope = app.Services.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<AppDBContent>();
				DBObjects.Initial(context);
			}

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
