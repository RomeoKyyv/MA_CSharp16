using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Консулечка";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Read!");
            Console.WriteLine("Hello Debug!");
            Console.WriteLine("Enter your name, pls");
            string name = Console.ReadLine();
            Console.Write("Hi, ");
            Console.WriteLine(name);
            Console.Beep(300, 1000);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
