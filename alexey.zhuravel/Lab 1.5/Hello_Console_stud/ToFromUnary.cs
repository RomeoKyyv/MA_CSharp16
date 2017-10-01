using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Console_stud
{
    class ToFromUnary
    {

        public void Init()
        {

            string binary;

            Console.WriteLine("Please enter variable 1: ");
            uint uintVar1 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Please enter variable 2: ");
            uint uintVar2 = Convert.ToUInt32(Console.ReadLine());

            ToFromBinary toFromBinary = new ToFromBinary();

            string UnitBinary1 = toFromBinary.ConvertToBinary(uintVar1);
            string UnitBinary2 = toFromBinary.ConvertToBinary(uintVar2);

            binary = UnitBinary1 + "#" + UnitBinary2;
            Console.WriteLine("binary equals to {0}", binary);

            while(binary.Contains("1#1"))
            {
                binary = binary.Replace("1#1", "#");
            }

            Console.WriteLine("String after replacement is {0}", binary);

            binary = binary.Replace("#", "");

            Console.WriteLine("Final result is {0}", binary);
        }
    }
}

//Declare int and string variables for decimal and binary presentations
//Implement two positive integer variables input
//To present each of them in the form of unary string use for loop
//Use concatenation of these two strings 
//Note it is necessary to use some symbol ( for example “#”) to separate
//Check the numbers on the equality 0
//Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
//Delete the '#' from algorithm result
//Output the result 