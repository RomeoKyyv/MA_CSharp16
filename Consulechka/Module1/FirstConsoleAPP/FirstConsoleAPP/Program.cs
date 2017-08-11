using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Console 18+");
            Console.ForegroundColor = ConsoleColor.Blue;
            int q, w;
            Console.Write("Whats your name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("HI, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input first number, pls ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            q = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input second number, pls ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            w = int.Parse(Console.ReadLine());
            if (q<10 && w<10)
            {
                Console.WriteLine("Value of q = {0},w = {1}", q, w);
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i != 9)
                    {
                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("{0}", i);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("{0}", i);
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Value of q = {0},w = {1}", q, w);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EndOfCircle");
                        Console.Beep(300, 1000);
                        Console.ResetColor();
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
