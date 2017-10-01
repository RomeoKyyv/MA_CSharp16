using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators
{
    class Factorial
    {
        public void Init()
        {
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
            while (true)
            {            
                Console.Write("Your number = ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Factorial of {0} = {1}", num, Fact(num));
                Console.WriteLine();
            }
        }

        //-------------------------------------------------------------

        long Fact(int num)
        {
            long result = 1;
            if (num == 0) { num = 1; }

            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
