using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProductLinq.Inventory.Categories;

namespace ProductLinq.Inventory
{


    public class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Name = "Sneakers",
                    Price = 50000,
                   Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Name = "Joggers", 
                    Price = 24000,
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                 new Inventory()
                {
                    Name = "Belt",
                    Price = 26000,
                  Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                }
            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 1,
                    Name = "Adidas", EntryDate = DateTime.Now, Price = 5000,
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Nike", EntryDate = DateTime.Now, Price = 7000,
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "Puma", EntryDate = DateTime.Now, Price = 3500,
                    Categories = new List<Category>{ GetCategories()[0] }
                }
            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[3]
            {
                new Category(){ Name = "FootWears"},
                 new Category(){ Name = "Joggers"},
                    new Category(){ Name = "Socks"},
            };

            return categories.ToList();
        }
    }
}
