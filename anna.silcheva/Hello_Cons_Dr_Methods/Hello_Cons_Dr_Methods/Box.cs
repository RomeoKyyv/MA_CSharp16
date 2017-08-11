using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        public int X { set; get; }
        public int Y { set; get; }
        public int Wigth { set; get; }
        public int Height { set; get; }
        public string Symbol { set; get; }
        public string Message { set;  get; }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw()
        {
            Console.WriteLine("Please enter coordinate x:");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter coordinate y:");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter wigth of rectangle:");
            Wigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter height of rectangle:");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter some symbol like *, +, .");
            Symbol = Console.ReadLine();
            Console.WriteLine("Please enter your message");
            Message = Console.ReadLine();
            int z = (X+Wigth)/2;
            int w = (Y+Height)/2;
            Console.SetCursorPosition(z, w);
            Console.Write(Message);

            for (int i = X; i < (X + Wigth); i++)
			{
				Console.SetCursorPosition(i, Y);
				Console.Write(Symbol);
				Console.SetCursorPosition(i, Y+ Height-1);
				Console.Write(Symbol);
			}

			for (int i = Y; i < (Y + Height); i++)
			{
				Console.SetCursorPosition(X, i);
				Console.Write(Symbol);
				Console.SetCursorPosition(X+ Wigth-1, i);
				Console.Write(Symbol);
			}
            

        }

		//3.  Implement private method draw() with parameters 
		//for start position, width and height, symbol, message
		//Change the message in the method to return the Box square
		//Use Console.SetCursorPosition() method
		//Trim the message if necessary


	}
}
