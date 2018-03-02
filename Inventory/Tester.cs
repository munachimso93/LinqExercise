using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq.Inventory
{
    public class Tester
    {
        public static void Main()
       {
            var a = InventoryManager.GetInventories();

            foreach (var item in a)
            {
                Console.WriteLine(item.Price);
            }

            var SumOfPrice = a.Sum(s => s.Price);

            
                Console.WriteLine(SumOfPrice);
                Console.ReadLine();
            

            
       }
    }
}
