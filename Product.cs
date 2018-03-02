using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq
{
    internal class product
    {
        static void Main(String[] args)
        {
            List<Product> ProductList = new List<Product>()
            {
                new Product(){ID = 1, Name = "Noodles"},
                new Product(){ID = 2, Name = "Rice"},
                new Product(){ID = 3, Name = "Beans"},
                new Product(){ID = 4, Name = "Meat"},
                new Product(){ID = 5, Name = "Spoon"},

                
            };
            var a = ProductList.Where(x => x.Name == "Noodles").OrderByDescending(x => x.ID);

            foreach (var item in a)
            {
                Console.WriteLine("{0}:{1}", item.ID,item.Name);
                Console.Read();
            }
          
        }

  
        
    }
}
