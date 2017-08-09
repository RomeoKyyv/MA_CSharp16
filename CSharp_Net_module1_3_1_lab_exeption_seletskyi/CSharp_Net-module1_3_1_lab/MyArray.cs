using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int []arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    this.arr = new int[size];

                    // 1) assign some value to cell of array arr, which index is out of range

                    for (int i = 0; i < arr.Length; i++)
                        this.arr[i] = arr[i] / arr[i + 1];
                    this.arr[5] =1;

                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array


                    //NullReferenceException

                }
                // 2) catch exception index out of rage
                catch 
                {
                    Console.WriteLine("index out of rage");// output message 
                    throw;
                }
            }
            // 4) catch devision by 0 exception
            catch
            {
               Console.WriteLine("Div by zero"); // output message 
            }

            // 6) add catch block for null reference exception of outside block try  
            // change the code to execute this block (any method of any class)
            //catch 
            {
               
            }
        }
    }
}
