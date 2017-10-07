using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            string s;
            int r = 0;
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing
            s=Console.ReadLine(); // need 3
            r = Convert.ToInt32(s);
            if (r == 3)
            {
                s = Console.ReadLine();//need 8
                r = Convert.ToInt32(s);
                               if (r == 8)
                {
                    s = Console.ReadLine();// need 2 or 1
                    r = Convert.ToInt32(s);

                    if ((r == 1) | (r == 2))
                    {
                        s = Console.ReadLine();// need 7
                        r = Convert.ToInt32(s);
                        if (r == 7)
                        {
                            s = Console.ReadLine();// need 2 or 1
                            r = Convert.ToInt32(s);
                            if (r == 2 | r == 1)
                            {
                                s = Console.ReadLine();// 8
                                r = Convert.ToInt32(s);
                                if (r == 8)
                                {
                                    s = Console.ReadLine();// 3
                                    r = Convert.ToInt32(s);
                                    if (r == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("   You win!!!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Sorry, but you lose");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Sorry, but you lose");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sorry, but you lose");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry, but you lose");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, but you lose");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, but you lose");
                }

            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, but you lose");

            }
        }
        #endregion
        
        #region calculator
        static void Calculator()
        {
            int c = 0;
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                    
                case 1:
                    {
                       int a = 0;
                        int b = 0;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Multi={0}", a * b);
                        break;
                    }
                case 2:
                    {
                        int a = 0;
                        int b = 0;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Div={0}", a / b);
                        break;
                    }
                case 3:
                    {
                        int a = 0;
                        int b = 0;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Add={0}", a + b);
                        break;
                    }
                case 4:
                    {
                        int a = 0;
                        int b = 0;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sub={0}", a - b);
                        break;
                    }
                case 5:
                    {
                        int a = 0;
                        int b = 0;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Exp={0}", Math.Pow(a, b));
                        break;
                    }
            } 
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion
     
        #region Factorial
        static void Factorial_calculation()
        {
            string s;
            int n = 0;
            int r = 1;
            // Implement input of the number
            Console.WriteLine("Input the number for factorial calc");
            s=Console.ReadLine();
            n = Convert.ToInt32(s);
            // Implement input the for circle to calculate factorial of the number
            for (int i = 2; i <= n; ++i)
            {
                r=r*i; 
            }
                // Output the result
                Console.WriteLine("Result of calc = {0}", r);
        }
        #endregion
    }
}
