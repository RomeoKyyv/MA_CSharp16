using System;
using System.IO;

namespace CSharp_Net_module1_3_1_lab
{
    class Program
    {
        static int[] Arr = { 1, 2, 3, 4, 5, 6 };
        int[] A = new int [10];
        static void Main(string[] args)
      
            {
                //TestTryCatch InstTestTryCatch = new TestTryCatch();
                 TestTryCatch.GetInt(Arr, 2);
                CatchExceptionClass cec = new CatchExceptionClass();
                cec.CatchExceptionMethod();
            }
            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception
           

        }
    }

