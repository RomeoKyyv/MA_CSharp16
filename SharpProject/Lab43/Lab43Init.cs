using System;

namespace SharpProject.Lab43
{
    public class Lab43Init
    {
        public Lab43Init()
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