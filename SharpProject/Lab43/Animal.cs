using System;

namespace SharpProject.Lab43
{
    public class Animal : IComparable
    {
        public int Weight { get; private set; }
        public string Genus { get; private set; }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public static void SortWeightByAscending()
        {
        }

        public static void SortWeightByDescending()
        {
        }
    }
}