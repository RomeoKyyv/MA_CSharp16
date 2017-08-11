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

                //int[] arr = new int[4] { 1, 4, 8, 5 };
                //ma.Assign(arr, 4);
                int[] ar = new int[4] { 1, 9, 8, 5 };
                //arr[1] = 0;
                //int[] ar = null;
                ma.Assign(ar, 4);
                //Console.WriteLine("{3}", ar[3]);
            }

            // 8) catch all other exceptions here
            catch (System.ArrayTypeMismatchException mm)
            {
                Console.WriteLine(mm.Message);
                Console.WriteLine("This is Type Mismatch Exception");
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite
            }
            catch (Exception e)
            {
                e.HelpLink = "www";
                Console.WriteLine(e.HelpLink);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);

            }
          

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("Finally!");
            }
        }
    }
}
