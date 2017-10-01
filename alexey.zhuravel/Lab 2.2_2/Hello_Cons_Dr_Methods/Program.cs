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
                new Box(50, 4, '*', 10, 8).Draw();

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

//Implement start position, width and height, symbol, message input

//Create Box class instance

//Use  Box.Draw() method