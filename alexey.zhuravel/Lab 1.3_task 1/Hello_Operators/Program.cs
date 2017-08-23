using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello_Operators;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }


//---------------------------------------------------------------------
        static void Init()
        {
            Farmer farm = new Farmer();
            Calculator calc = new Calculator();
            Factorial fact = new Factorial();


            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factorial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    farm.Init();
                    Console.WriteLine("");
                    break;
                case 2:
                    calc.Init();
                    Console.WriteLine("");
                    break;
                case 3:
                    fact.Init();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }


    }
}
