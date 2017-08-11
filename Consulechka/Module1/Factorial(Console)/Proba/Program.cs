using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Консулечка";
            int n;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите число для факториала");
            Console.ForegroundColor = ConsoleColor.Blue;
            n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Факториал числа "+ n +" = "+ factorial);
            Console.ReadKey();

        }
    }
}
