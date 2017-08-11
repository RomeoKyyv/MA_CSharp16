using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            Console.Title = "Консулечка";
            int n;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Input N");
            Console.ForegroundColor = ConsoleColor.Red;
            n = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            fact(n);
            Console.ReadKey();
        }
        static public void fact(int n)
        {
            //n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Факториал числа " + n + " = " + factorial);
        }
        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator

    }

    

}
