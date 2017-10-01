using System;
using System.Threading;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        static void Init()
        {
            ToFromBinary toFromBinary = new ToFromBinary();
            ToFromUnary toFromUnary = new ToFromUnary();
            MyMusic myMusic = new MyMusic();
            Morse morse = new Morse();

            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                toFromUnary.Init();
                                Console.WriteLine("");
                                break;
                            case 2:
                                toFromBinary.Init();
                                Console.WriteLine("");
                                break;
                            case 3:
                                myMusic.Init();
                                Console.WriteLine("");
                                break;
                            case 4:
                                morse.Init();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
