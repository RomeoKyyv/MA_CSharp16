using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators
{
    class Calculator
    {
        public void Init()
        {
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 

            this.Selection();
        }

        //-------------------------------------------------------------
        void Selection()
            {
                while(true)
                {
                    Console.Write("Your choice is ");
                    int option = int.Parse(Console.ReadLine());

                    Console.Write("Number 1 = ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Number 2 = ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Result = {0}", num1 * num2);
                            break;
                        case 2:
                            Console.WriteLine("Result = {0}", ( (double)num1 / (double)num2) );
                            break;
                        case 3:
                            Console.WriteLine("Result = {0}", num1 + num2);
                            break;
                        case 4:
                            Console.WriteLine("Result = {0}", num1 - num2);
                            break;
                        case 5:
                            Console.WriteLine("Result = {0}", num1 ^ num2);
                            break;
                        default:
                            Console.WriteLine("You selected incorrect operation");
                            break;
                    }

                Console.WriteLine();
                }
            }        
    }
}
