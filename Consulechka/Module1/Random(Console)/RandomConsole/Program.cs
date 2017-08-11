using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Консулечка";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Давай сыграем в игру");
            Thread.Sleep(1500);
            Console.WriteLine("Ты должен будешь угадать число от 0 до 100");
            Thread.Sleep(1500);
            Console.WriteLine("У тебя будет 10 попыток");
            Thread.Sleep(1500);
            Console.WriteLine("Не будем терять времени, у тебя его и так нет:)" +
                "");
            const int MyMax = 200;
            int MyNum;
            Random random = new Random();
            int consoleNum = random.Next(MyMax) + 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ГЕНЕРАЦИЯ ЧИСЛА ЗАВЕРШЕНА");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Впиши число и мы узнаем на чьей стороне сегодня удача");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                MyNum = int.Parse(Console.ReadLine());
                if (MyNum > consoleNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Попробуй меньше число");
                }
                else if (MyNum < consoleNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Попробуй больше число");
                }
                else if (MyNum == consoleNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Молодец ты угадал:*");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ты проиграл");
                }
            }
            Console.ReadKey();
        }
    }
}
