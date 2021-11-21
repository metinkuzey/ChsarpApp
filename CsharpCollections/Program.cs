using System;
using System.Collections.Generic;

namespace CsharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Metin", "Kuzey", "Jack", "London" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Array has a limited size. Because we have to set its dimension when we are creating an aaray.

            // We want to add new item to my array, we should use List.
            List<string> namesList = new List<string> { "Metin", "Kuzey", "Jack", "London" };
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }

            namesList.Add("Liverpool");

            Console.WriteLine("Added a item to list. New items listed below.");

            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }


        }
    }
}

