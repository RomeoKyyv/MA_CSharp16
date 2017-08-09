using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public  class TestTryCatch
{
    public static int GetInt(   int [] array, int index)
    {
        try
        {
            return array[index];
        }
        catch (System.IndexOutOfRangeException e)  // CS0168
        {
            System.Console.WriteLine(e.Message);
            // Set IndexOutOfRangeException to the new exception's InnerException.
           throw new System.ArgumentOutOfRangeException("index parameter is out of range.", e);
        }
    }
}
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

                int[] arr = new int[4] { 1, 0, 8, 5 };
                ma.Assign(arr, 4);

            }
           
                // 8) catch all other exceptions here
            catch
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {

            }
        }
    }
}
