using System;
using System.Collections.Generic;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 10,
                ["hammer, cross pein"] = 20,
                ["screwdriver, Phillips #2"] = 30
            };
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",25}|{"Quantity",10}|");
            foreach (var item in inventory)
            Console.WriteLine($"|{item.Key,25}|{item.Value,10}|");
            Console.ReadKey();
        }
    }
}
