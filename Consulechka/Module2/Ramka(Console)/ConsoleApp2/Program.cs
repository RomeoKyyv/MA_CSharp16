using System;
using System.Collections.Generic;
using System.Text;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Консулечка";
            Box Lucky = new Box();
            Console.WriteLine("X");
            Lucky.PositionX = int.Parse(Console.ReadLine());
            Console.WriteLine("Y");
            Lucky.PositionY = int.Parse(Console.ReadLine());
            Console.WriteLine("Width");
            Lucky.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height");
            Lucky.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Message");
            Lucky.Message = Console.ReadLine();
            Console.WriteLine("Symbol * + .");
            Lucky.Symbol = char.Parse(Console.ReadLine());
            Lucky.draw();
        }
    }
    public class Box
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Message { get; set; }
        public char Symbol { get; set; }
        public void draw()
        {
            Draw(PositionX, PositionY,Width,Height,Message,Symbol);
        }
        private void Draw(int x,int y,int width,int height, string text,char symbol)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < width - 2; i++)
            {
                Console.CursorTop = y;
                Console.CursorLeft = x + 1 + i;
                Console.Write(symbol);

                Console.CursorTop = y + height - 1;
                Console.CursorLeft = x + 1 + i;
                Console.Write(symbol);
            }
            for (int i = 0; i < height - 2; i++)
            {
                Console.CursorTop = y + 1 + i;
                Console.CursorLeft = x;
                Console.Write(symbol);

                Console.CursorTop = y + 1 + i;
                Console.CursorLeft = x + width - 1;
                Console.Write(symbol);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            int z = text.Length / 2;
            if (text.Length < width / 2)
            {
                Console.SetCursorPosition(x + width / 2 - z, y + height / 2);
                Console.Write(text);
            }
            else Console.Write("Ky-Ky");
            Console.WriteLine("\n\n\n");
            Console.ReadKey();
        }
    }
}




//switch (caser)
//{
//    case 1:
//        symbol = '+';
//        break;
//    case 2:
//        symbol = '+';
//        break;
//    case 3:
//        symbol = '.';
//        break;
//    default:
//        Console.WriteLine("Error");
//        break;
//}