using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string outputText = "";
                int posY = 1;
                int posX = 1;
                int tabWidht = 10;
                int tabHeight = 10;
                char symbolChar = ' ';

                Console.WriteLine("Do you want box position draw by default?");
                Console.WriteLine("default - y ; enter data - other key .");

                Box box = new Box();

                char userChoose = Console.ReadKey().KeyChar;
                if (userChoose != 'y')
                {
                    Console.Clear();
                    Console.WriteLine("What text need output?");
                    outputText = Console.ReadLine();

                    Console.WriteLine("Ok. Tnx.");
                    Console.WriteLine("Enter position start graw.");
                    Console.WriteLine("Enter 'y':");
                    string userMsgText = Console.ReadLine();
                    if (int.TryParse(userMsgText, out posY))
                    {
                        Console.WriteLine("Enter 'x':");
                        userMsgText = Console.ReadLine();
                        if (int.TryParse(userMsgText, out posX))
                        {
                            Console.WriteLine("Enter widht:");
                            userMsgText = Console.ReadLine();
                            if (int.TryParse(userMsgText, out tabWidht))
                            {
                                Console.WriteLine("Enter height:");
                                userMsgText = Console.ReadLine();
                                if (int.TryParse(userMsgText, out tabHeight))
                                {
                                    Console.WriteLine("Choose char: *, + or .");
                                    symbolChar = Console.ReadKey().KeyChar;
                                }
                                else
                                    return;
                            }
                            else
                                return;
                        }
                        else
                            return;
                    }
                    else
                        return;

                    box = new Box()
                    {
                        OutputText = outputText,
                        PosY = posY,
                        PosX = posX,
                        TabWidht = tabWidht,
                        TabHeight = tabHeight,
                        SymbolChar = symbolChar
                    };
                }

                Console.Clear();

                box.InitializeField();
                box.Draw();


                Console.ReadKey();

                //Implement start position, width and height, symbol, message input
               
                //Create Box class instance

                //Use  Box.Draw() method

                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
