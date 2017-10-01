using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;


namespace Hello_Cons_Dr_Methods
{

	class Program
    {
		
		static void Main(string[] args)
        {
            try
            {
				//Implement start position, width and height, symbol, message input

				//Create Box class instance
				Box box = new Box();
				box.Draw();
				//Use  Box.Draw() method
				


				Console.WriteLine("");
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
