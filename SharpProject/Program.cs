using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using SharpProject.Airport;
using SharpProject.Lab41;
using SharpProject.Lab43;
using SharpProject.Properties;
using SharpProject.sql;

namespace SharpProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animals animals = new Animals();
            pring(animals);
            Console.WriteLine("==============================");
            pring(animals);
            Console.WriteLine("==============================");
            Array.Sort(animals.AnimalsArray);
            pring(animals);
            Console.WriteLine("==============================");
            Array.Sort(animals.AnimalsArray);
            pring(animals);
            Console.WriteLine("==============================");
        }

        private static void pring(Animals animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Genus);
                Console.WriteLine(animal.Weight);
            }
        }
    }
}