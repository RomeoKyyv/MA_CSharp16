using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Console_stud
{
    class ToFromBinary
    {
        //-------------------------------------------------------------
        public void Init()
        {
            Console.WriteLine("Please enter a positive integer: ");
            positiveInt = Convert.ToUInt32(Console.ReadLine());
            
            binary = ConvertToBinary(positiveInt);
            Console.WriteLine("{0} converted to binary is {1}", positiveInt, binary);
        }

        //-------------------------------------------------------------
        public string ConvertToBinary(uint positiveInt)
        {
            this.toBinary(positiveInt);
            this.binary = reverse(binary);
            return binary;
        }

        //-------------------------------------------------------------
        string toBinary(uint positiveInt)
        {
            uint integerPart = positiveInt;
            uint fraction;


            while(integerPart != 0)
            {
                fraction = integerPart % 2;
                integerPart /= 2;
                binary += fraction.ToString();
            }

            return binary;
        }

        //-------------------------------------------------------------
        string reverse(string binary)
        {
            char[] charArray = binary.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }

        //-------------------------------------------------------------
        string binary = "";
        uint positiveInt;
    }
}

//Implement positive integer variable input

//Present it like binary string
//   For example, 4 as 100
//Use modulus operator to obtain the remainder  (n % 2) 
//and divide variable by 2 in the loop

//Use the ToCharArray() method to transform string to chararray
//and Array.Reverse() method