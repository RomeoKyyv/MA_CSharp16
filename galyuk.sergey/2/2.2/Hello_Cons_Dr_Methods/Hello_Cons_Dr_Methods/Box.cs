using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public string OutputText { private get; set; }
        public int PosY
        {
            get; set;
            //get
            //{
            //    return PosY;
            //}
            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("PosY need >= 0");
            //        value = 0;
            //    }
            //}
        }
        public int PosX
        {
            get; set;
            //get
            //{
            //    return PosX;
            //}
            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("PosX need >= 0");
            //        value = 0;
            //    }
            //}
        }
        public int TabWidht
        {
            get; set;
            //get
            //{
            //    return TabWidht;
            //}
            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("Widht need >= 0");
            //        value = 0;
            //    }
            //}
        }
        public int TabHeight
        {
            get; set;
            //get
            //{
            //    return TabHeight;
            //}
            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("Height need >= 0");
            //        value = 0;
            //    }
            //}
        }
        public char SymbolChar { private get; set; }
        private string outputTextInLine;

        public Box()
        {
            OutputText = "Hello world!";
            PosY = 5;
            PosX = 10;
            TabWidht = 50;
            TabHeight = 9;
            SymbolChar = '*';
        }

        public bool InitializeField()
        {
            DefineResultText();
            PrepareField();
            return true;
        }

        private void DefineResultText()
        {
            outputTextInLine = OutputText;

            if (outputTextInLine.Length > TabWidht)
                outputTextInLine = outputTextInLine.Remove(TabWidht - 1);

            while (outputTextInLine.Length < TabWidht)
                outputTextInLine = " " + outputTextInLine + " ";

            while (outputTextInLine.Length - 1 > TabWidht)
                outputTextInLine = outputTextInLine.Remove(outputTextInLine.Length - 1);
        }
        private void PrepareField()
        {
            Console.SetCursorPosition(PosX, PosY);
        }
        public void Draw()
        {
            bool textDisplayed = false;
            for (int curHeight = 0; curHeight < TabHeight; curHeight++)
            {
                string textInLine = "";

                Console.SetCursorPosition(PosX, curHeight + PosY);

                for (; textInLine.Length <= TabWidht;)
                {
                    if (curHeight == 0 || curHeight == TabHeight - 1)
                        textInLine += SymbolChar;

                    else if (curHeight == TabHeight / 2 && !textDisplayed)
                    {
                        textInLine += outputTextInLine;
                        textDisplayed = true;
                    }

                    else
                        textInLine += " ";
                }
                textInLine = SymbolChar + textInLine + SymbolChar;

                Console.WriteLine(textInLine);
            }
            Console.WriteLine();
            Console.WriteLine();
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
    }
}
