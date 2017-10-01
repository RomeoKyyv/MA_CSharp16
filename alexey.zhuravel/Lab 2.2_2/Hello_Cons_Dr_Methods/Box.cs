using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public Box(int Width, int Height, char Symbol = '*', int X = 0, int Y = 0)
        {
            this.X = X;
            this.Y = Y;
            this.Symbol = Symbol;
            this.Width = Width;
            this.Height = Height;
        }

        //-------------------------------------------------------------
        public Box(int Width, int Height, char Symbol) :
                this(Width, Height, Symbol, 0, 0)
        {
            this.Symbol = Symbol;
            this.Width = Width;
            this.Height = Height;
        }

        //-------------------------------------------------------------
        public void Draw()
        {

            //Console.WriteLine(X.ToString() +", " + Y.ToString() + ", " + Symbol + ", " + Width.ToString() + ", " + Height.ToString());

            Console.SetCursorPosition(X, Y);
            Console.Write(new string (Symbol, Width));
            tempX = X;
            tempY = Y;

            Console.SetCursorPosition(++tempX, ++tempY);
            Console.WriteLine("HELLO!");


            for (int i = 1; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y+i);
                Console.Write(Symbol);
                Console.SetCursorPosition(X+Width, Y + i);
                Console.Write(Symbol);
            }
            Console.SetCursorPosition(X, Y + Height);
            Console.Write(new string(Symbol, Width));
            Console.WriteLine();
        }

        //-------------------------------------------------------------
        public int              X { get; set; }
        public int              Y { get; set; }
        public char             Symbol { get; set; }
        public int              Width { get; set; }
        public int              Height { get; set; }
        int                     tempX;
        int                     tempY;
    }
}

//1.  Implement public  auto-implement properties for start position (point position)
//auto-implement properties for width and height of the box
//and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
//and a message inside the box

//2.  Implement public Draw() method
//to define start position, width and height, symbol, message  according to properties
//Use Math.Min() and Math.Max() methods
//Use draw() to draw the box with message

//3.  Implement private method draw() with parameters 
//for start position, width and height, symbol, message
//Change the message in the method to return the Box square
//Use Console.SetCursorPosition() method
//Trim the message if necessary
