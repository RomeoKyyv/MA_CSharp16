using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States.States
{
    class dbOfStates
    {

        public dbOfStates()
        {

        }

        //-------------------------------------------------------------
        public void Iterate()
        {
            do
            {
                Console.WriteLine("Please make your choice:");
                Console.WriteLine("1. Iterate.");
                Console.WriteLine("2. Exit.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        KingdomOfEngland.Iterate();
                        MonarchySpain.Iterate();
                        RepublicOfFrance.Iterate();
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please make a valid choice:");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Period: \t\t{0}", periodNo);
                Console.ForegroundColor = ConsoleColor.White;

                periodNo++;
            }
            while (exit == false);

            Console.WriteLine("GAME OVER");
        }

        //-------------------------------------------------------------
        static int                      periodNo = 1;
        bool                            exit = false;

        Kingdom KingdomOfEngland =      new Kingdom("Королевство Англия", 200000, 35000, new List<string> { "Лондон", "Йоркшир", "Эдинбург" }, 1200, 1000000);
        Monarchy MonarchySpain =        new Monarchy("Монархия Испания", 350000, 78000, new List<string> { "Мадрид", "Барселона", "Валенсия", "Наварра", "Севилья" }, 3500, 2200000);
        Republic RepublicOfFrance =     new Republic("Республика Франция", 40000, 15000, new List<string> { "Париж", "Марсель" }, 1800, 400000);

    }
}
