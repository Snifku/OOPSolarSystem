using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolarSystem
{
    class Program
    {
        public class Item
        {
            string name;
            int mass;


            public Item(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
                Console.WriteLine($"Item {name} created.");
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }

        }
        static void Main(string[] args)
        {
            Planet();
        }

        public static void Planet()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"planets.txt";
            List<Item> planetItems = new List<Item>();
            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine($"Item: {tempArray[0]}");
                //Console.WriteLine($"Mass: {tempArray[1]}");
                Item newItem = new Item(tempArray[0], Int32.Parse(tempArray[1]));
                planetItems.Add(newItem);



            }
            Console.WriteLine("your planets: ");
            int total = 0;

            foreach (Item item in planetItems)
            {
                Console.WriteLine($"Item: {item.Name}; Mass: {item.Mass}");
                total += item.Mass;
            }

            Console.WriteLine($"Your planets: ");

        }


    }
}
