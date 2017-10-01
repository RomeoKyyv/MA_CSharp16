using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Guess
    {
        //-------------------------------------------------------------
        public void Init()
        {
            this.GuessedNumber();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The computer settled a number between 1 and 100. Try to guess it {0} ", guessednumber);

            Console.ForegroundColor = ConsoleColor.Cyan;
            int num;

            do
            {
                Console.Write("Please enter your number: ");
                num = int.Parse(Console.ReadLine());
                InformAboutCheckTheNumber(num);
            }
            while (!CheckTheNumber(num));

            Console.WriteLine("You guessed it! Congratulations!");
        }

        //-------------------------------------------------------------
        bool CheckTheNumber(int num)
        {
            if (num == guessednumber)
                return true;
            else
                return false;
        }

        //-------------------------------------------------------------
        void InformAboutCheckTheNumber(int num)
        {
            if (num < guessednumber)
                Console.WriteLine("Your Number is less than the settled one. Please try again.");
            else if (num > guessednumber)
                Console.WriteLine("Your Number is more than the settled one. Please try again.");
        }

        //-------------------------------------------------------------
        int GuessedNumber()
        {
            Random rnd = new Random();
            guessednumber = rnd.Next(1, 100);

            return guessednumber;
        }

        //-------------------------------------------------------------
        int guessednumber;

    }
}
