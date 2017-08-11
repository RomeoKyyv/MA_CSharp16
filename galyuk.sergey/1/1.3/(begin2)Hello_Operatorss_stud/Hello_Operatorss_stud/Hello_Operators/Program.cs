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

            startProgram:

            Console.Clear();

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


            Console.ForegroundColor = ConsoleColor.Gray;
            const string variant1 = "3817283";
            const string variant2 = "3827183";

            string userString;
            string userVariant = "";

            bool endGame = false;
            do
            {
                userString = Console.ReadLine();

                if (int.TryParse(userString, out int userID)
                    && userID >= 1
                    && userID <=8)
                {
                    userVariant = userVariant + userString;

                    string leftPartVariant1 = variant1.Substring(0, userVariant.Length);
                    string leftPartVariant2 = variant2.Substring(0, userVariant.Length);

                    if (userVariant == leftPartVariant1
                        || userVariant == leftPartVariant2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Ok. You mooved: " + userVariant);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Oops. Error. Restart game or exit?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("(r - restart or other char - exit)");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        if (Console.ReadLine() == "r")
                            goto startProgram;
                        else
                        {
                            endGame = true;
                            break;
                        };
                    }
                }
                else if (userString == "exit")
                {
                    endGame = true;
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. You need input number on 1 to 8");
                    Console.WriteLine("If you entered 'exit' you will be exit this game.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                };

            } while (variant1 != userVariant && variant2 != userVariant);

            if (endGame)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tnx for game.");
                Console.WriteLine("Bye.");
                Console.WriteLine("");
            }
            else if (variant1 == userVariant
                || variant2 == userVariant)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine("Yeah!!! You win. You carried wolf, goat and cabbage.");
                Console.WriteLine("");
            };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Press any key for exit this game.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        #endregion

        #region calculator
        static void Calculator()
        {

            startCalculator:

            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 


            Console.WriteLine("    or 'exit' for exit programm.");

            Console.WriteLine("");

            bool exitGame = false;

            string userString = Console.ReadLine();

            if (int.TryParse(userString, out int ID)
                && ID >= 1
                && ID <=5)
            {
                bool mul = false;
                bool div = false;
                bool add = false;
                bool sub = false;
                bool exp = false;

                string infoText = "You choice - ";

                switch (ID)
                {
                    case 1:
                        mul = true;
                        infoText = infoText + "multiplication";
                        break;
                    case 2:
                        div = true;
                        infoText = infoText + "divide";
                        break;
                    case 3:
                        add = true;
                        infoText = infoText + "addition";
                        break;
                    case 4:
                        sub = true;
                        infoText = infoText + "subtraction";
                        break;
                    case 5:
                        exp = true;
                        infoText = infoText + "exponentiation";
                        break;
                }

                infoText = infoText + ".";

                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(infoText);

                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please, input one or two numbers.");

                Console.WriteLine("");

                bool value1Entered = false, value2Entered = false;

                Console.WriteLine("Enter first number:");

                if (double.TryParse(Console.ReadLine(), out double value1))
                    value1Entered = true;
                
                Console.WriteLine("Enter second number:");

                if (double.TryParse(Console.ReadLine(), out double value2))
                    value2Entered = true;
                
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("");

                string textResult = "";

                if (value1Entered && value2Entered)
                    textResult = Calculation(mul, div, add, sub, exp, value1, value2);
                
                else if (value1Entered)
                    textResult = Calculation(mul, div, add, sub, exp, value1, value1);
                
                else if (value2Entered)
                    textResult = Calculation(mul, div, add, sub, exp, value2, value2);
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. You neeed entered one or two numbers.");
                    exitGame = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                if (textResult != "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(textResult);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");

                    goto startCalculator;
                }
            }
            else if (userString == "exit")
                exitGame = true;
            
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Error. You need input on 1 to 5.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
            };


            if (exitGame)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Exit.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray; 
            };

        }

        private static string Calculation(bool mul, bool div, bool add, bool sub, bool exp, double value1, double value2)
        {
            string textResult = "";

            double result;

            if (mul)
            {
                result = value1 * value2;
                textResult = "" + value1 + " * " + value2 + " = " + result;
            }
            else if (div)
            {
                result = value1 / value2;
                textResult = "" + value1 + " / " + value2 + " = " + result;
            }
            else if (add)
            {
                result = value1 + value2;
                textResult = "" + value1 + " + " + value2 + " = " + result;
            }
            else if (sub)
            {
                result = value1 - value2;
                textResult = "" + value1 + " - " + value2 + " = " + result;
            }
            else if (exp)
            {
                result = Math.Pow(value1, value2);
                textResult = "" + value1 + " pow " + value2 + " = " + result;
            }
            return textResult;
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result

            startFactorial:

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please, enter max number:");
            Console.ForegroundColor = ConsoleColor.Gray;

            int maxInd;
            if (int.TryParse(Console.ReadLine(), out maxInd)
                && maxInd >= 0)
            {
                ulong result = 0;
                for (int i = 0; i <= maxInd; i++)
                {
                    result = (result == 0) ? 1 : result;
                    result = (i == 0) ? 1 : (ulong)i * result;
                }
                Console.WriteLine("");
                Console.WriteLine("{0}! = {1}.", maxInd, result);

                if (result > ulong.MaxValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. Exceeding the maximum allowed number.", maxInd, result);
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Repeat?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("y - repeat or other exit.");

                if (Console.ReadLine() == "y")
                    goto startFactorial;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. You need enter number on 1 to '...' .");
                Console.WriteLine("Repeat?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("y - repeat or other exit this program.");
                Console.ForegroundColor = ConsoleColor.Gray;

                if (Console.ReadLine() == "y")
                    goto startFactorial;
            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("bye.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion
    }
}
