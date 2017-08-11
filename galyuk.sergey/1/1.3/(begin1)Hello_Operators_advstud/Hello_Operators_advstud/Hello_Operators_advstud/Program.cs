using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MyMax = 200;
            const string defoultTitle = "Game. Find number.";

            int indGame = 0;
            int maxTry = 5;
            bool needAddTry = false;

            repeat:

            indGame++;

            if (needAddTry) maxTry += 3;

            Console.Title = defoultTitle + " (game " + indGame + ")";

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition

            //Console.WriteLine(Guess_number);

            int ind = 1;
            string userString;

            Console.WriteLine("Please, input number 1-200:");
            while (ind <= maxTry)
            {
                userString = Console.ReadLine();

                int userNumber;

                if (int.TryParse(userString, out userNumber))
                {
                    if (userNumber == Guess_number)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Yeah!!! You a Superman!!!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                    else if (userNumber <= Guess_number)
                    {
                        Console.WriteLine("{0} >> ?", userNumber);
                    }
                    else if (userNumber >= Guess_number)
                    {
                        Console.WriteLine("? << {0}", userNumber);
                    }
                    else if (userNumber > MyMax)
                    {
                        Console.WriteLine("You need input number in 1 to 200.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You need write a number");
                    continue;
                };

                ind++;
            }

            if (ind > maxTry)
            {
                needAddTry = true;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You lose. You have a {0} try :-((.", maxTry);

                const int pause = 1000;
                int i = 0;
                do
                {
                    i++;
                    Console.WriteLine("");
                    //Task.Delay(pause);
                    Thread.Sleep(pause);
                } while (i < 3);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Muhahahahahahhahahahah");

                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("");
                    Thread.Sleep(pause);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sorry :-))");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Do you want repeat game?");
            Console.WriteLine("(write 'yes' or 'no')");

            userString = Console.ReadLine();
            if (userString == "yes")
            {
                goto repeat;
            }
        }
    }
}
