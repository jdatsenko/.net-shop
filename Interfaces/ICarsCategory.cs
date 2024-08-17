using CarShop.Models;
using System.Collections.Generic;

namespace CarShop.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
