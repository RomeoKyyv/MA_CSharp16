using System;

namespace SharpProject.Lab42
{
    public class BaseClass<T> where T : new()
    {
        static void Swap<T>() where T : new()
        {
            T Puzzle = new T();
            Console.WriteLine("this is new T");
        }
    }
}