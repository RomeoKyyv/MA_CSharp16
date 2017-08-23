using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0

                int[] arr = new int[4] { 1, 4, 8, 5 };
                ma.Assign(arr, 4);

                arr[1] = 0;

            }
           
                // 8) catch all other exceptions here
            catch (Exception ex)
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("HelpLink - " + ex.HelpLink);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Message - " + ex.Message);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Source - " + ex.Source);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("StackTrace - " + ex.StackTrace);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("TargetSite - " + ex.TargetSite);

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("finally");
            }
        }
    }
}
