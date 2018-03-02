using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq.Inventory
{
    class Tester3
    {
        public static void Main()
        {
            var a = InventoryManager.GetInventories().OrderBy(x => x.Id).ThenBy(x => x.EntryDate);
            foreach (var item in a)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.EntryDate);
            }
            

            

            

        }
    }
}
