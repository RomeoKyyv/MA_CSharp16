using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpProject.Lab43
{
    public class Animals : IEnumerable
    {
        public Animal[] AnimalsArray = new Animal[]
        {
            new Animal(150, "Elepahnt"),
            new Animal(350, "Hippo"),
            new Animal(50, "Crocodile"),
            new Animal(800, "Colibri")
        };

        public IEnumerator GetEnumerator()
        {
            foreach (var animal in AnimalsArray)
            {
                yield return animal;
            }
        }
    }

    public class Animal : IComparable
    {
        public int Weight { get; private set; }
        public string Genus { get; private set; }

        public Animal(int weight, string genus)
        {
            Weight = weight;
            Genus = genus;
        }

        public int CompareTo(object obj)
        {
            return String.Compare(Genus, ((Animal) obj).Genus);
        }

        public static IComparer SortWeightByAscending()
        {
            return new WeightAscendingHelper();
        }

        public static IComparer SortGenusByDescending()
        {
            return new GeunsDescendingHelper();
        }

        private class GeunsDescendingHelper : IComparer
        {
            public int Compare(object animalLeft, object animalRight)
            {
                return String.Compare(animalLeft as string, animalRight as string);
            }
        }

        private class WeightAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                int weightLeft = (int) x;
                int weightRight = (int) x;
                if (weightLeft > weightRight)
                {
                    return 1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    public class AnimalComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}