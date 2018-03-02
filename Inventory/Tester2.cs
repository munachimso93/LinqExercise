using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq.Inventory
{
    class Tester2
    {
        public static void Main()
       {
            var a = InventoryManager.GetInventories().SkipWhile(x => x.Price > 50000);
            
            foreach (var item in a)
            {
                Console.WriteLine(item.Price);
                

            }
            
            var b = InventoryManager.GetInventories().TakeWhile( x => x.Price > 5000);
            foreach (var item in a)
            {
                Console.WriteLine(item.Price);


            }
            Console.ReadLine();
        }
         
    }
}
