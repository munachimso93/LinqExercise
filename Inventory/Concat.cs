using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq.Inventory
{
    class Concat
    {
        public static void Main()
        {
            var a = InventoryManager.GetInventories();
            var b = InventoryManager.FreshInventories();

            Console.WriteLine("concat");

            var concat = a.Concat(b);
            foreach (var item in concat)
            {
                Console.WriteLine($" {item.Id} {item.Name} : \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }
            Console.WriteLine();
            Console.WriteLine(".......Union....");

            var union = a.Union(b);
            foreach (var item in union)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }
            Console.WriteLine();
            Console.WriteLine("...Distinct...");

            var distinct = a.Distinct();
            foreach (var item in distinct)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }
            Console.WriteLine();
            Console.WriteLine("....Intersect...");

            var intersect = a.Intersect(b);
            foreach (var item in intersect)
            {
                Console.WriteLine($"{item.Id} {item.Name} : \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }
            Console.WriteLine();
            Console.WriteLine("....Except...");

            var except = a.Except(b);
            foreach (var item in except)
            {
                Console.WriteLine($"{ item.Id} { item.Name} : \t {item.EntryDate.ToString("MM:dd:yyyy hh:mm:ss")}");
            }


            
        }
    }
}
