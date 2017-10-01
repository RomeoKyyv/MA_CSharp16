using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators
{
    class Farmer
    {
        public void Init()
        {
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please, type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

            this.AttemptsAnalyzer();
        }

        //---------------------------------------------------------------------
        void AttemptsAnalyzer()
        {
            currentSequence = "";

            do
            {
                stepNo++;
                keySequenceElenent = int.Parse( Console.ReadLine());

                CurrentSequence(keySequenceElenent);
                Console.WriteLine("Your current sequence is {0}. You used {1} attempts. Please enter your next figure", currentSequence, stepNo);

                if (currentSequence == correctSequence1 || currentSequence == correctSequence2)
                {
                    this.Win();
                }
            }
            while (KeySequenceAnalyzer());

            this.Lose();
        }

        //---------------------------------------------------------------------
        bool KeySequenceAnalyzer()
        {
            string str1 = correctSequence1.Substring(0, stepNo);
            string str2 = correctSequence2.Substring(0, stepNo);

            if(currentSequence == str1 || currentSequence == str2)
            {
                return true;
            }

            else
            {
                return false;
            }            
        }

        //---------------------------------------------------------------------
        string CurrentSequence(int number)
        {
            string str = number.ToString();
            currentSequence += str;
            return currentSequence;
        }
        //---------------------------------------------------------------------
        void Win()
        {
            Console.WriteLine("You have won the game in {0} attempts! Congratulations! You are the champion!", stepNo);
            
            string str = Console.ReadLine();
            
            while (str != "y" || str == "n")
                {
                    Console.WriteLine("Do you want to play the game once more? (y/n)");
                    Console.ReadLine();
            }
        }

        void Lose()
        {
            string str = Console.ReadLine();
            while (str != "y" || str == "n")
            {
                Console.WriteLine("Unfortunately, you lost... Do you want to try ones more? (y/n)");
                Console.ReadLine();
            }
        }
        //---------------------------------------------------------------------
        int stepNo = 0;
        int keySequenceElenent;
        string currentSequence = "";
        const string correctSequence1 = "3817283";
        const string correctSequence2 = "3827183";
    }
}
