using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

                //Use  Box.Draw() method
                
                int a, b;
                Console.WriteLine("X:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Y:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("String:");
                string s = Console.ReadLine();
                int c = s.Length;
                //Console.SetCursorPosition(10, 10);
                for (int i = 0; i < b; i++) {
                    for (int j = 0; j < a; j++) {
                        Console.SetCursorPosition(10+j, 10+i);
                        if (i == 0) {
                            Console.Write("*");
                            Thread.Sleep(750);
                        
                        }
                        else if (i == b - 1)
                        {
                            Console.Write("#");
                            Thread.Sleep(750);

                        }
                            else if(i== b/2){
                                if (j == ((a - c) / 2)) { Console.Write(s); j += --c; }
                                else Console.Write("%");
                        }
                        else
                        {
                            if (j == 0 | j == a - 1) Console.Write("%");
                            else Console.Write(" ");
                            }
                        


                    }
                    Console.WriteLine();
                    Thread.Sleep(750);
                }



                    //Console.WriteLine("Press any key...");
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
