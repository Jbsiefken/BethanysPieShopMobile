using BethanysPieShopMobile.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShopMobile.Core.Repository
{
    public class PieRepository
    {

        private static readonly Dictionary<string, Category> AllCategories = new Dictionary<string, Category>()
        {
            {"Fruit pies", new Category {CategoryName = "Fruit pies"} },
            {"Cheese cakes", new Category {CategoryName = "Cheese cakes"} },
            {"Seasonal pies", new Category {CategoryName = "Seasonal pies"} }
        };

        private static readonly List<Pie> AllPies = new List<Pie>()
        {
            new Pie {PieId = 1, Name = "Apple Pie", Price = 12.95M, Category = AllCategories["Fruit pies"]},
            new Pie {PieId = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, Category = AllCategories["Cheese cakes"]},
            new Pie {PieId = 3, Name = "Cheese Cake", Price = 18.95M, Category = AllCategories["Cheese cake"]},
            new Pie {PieId = 4, Name = "Cherry Pie", Price = 15.95M, Category = AllCategories["Fruit pies"]},
            new Pie {PieId = 5, Name = "Christmas Apple Pie", Price = 13.95M, Category = AllCategories["Seasonal pies"]},
        };

        public List<Pie> GetAllPies()
        {
            return AllPies;
        }

        public List<Category> GetCategoriesWithPies()
        {
            foreach (var category in AllCategories.Values)
            {
                category.Pies = AllPies.Where(c => c.Category == category).ToList();
            }
            return AllCategories.Values.ToList();
        }

        public Pie GetPieById(int id)
        {
            return AllPies.FirstOrDefault(p => p.PieId == id);
        }

    }
}
