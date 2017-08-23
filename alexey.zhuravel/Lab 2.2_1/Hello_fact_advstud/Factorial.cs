using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Factorial
    {

        public void Fact()
        {
            this.Init();
            this.Calculate();
            Console.WriteLine($"Factorial of {val} is {fact}");
        }

        //-------------------------------------------------------------
        void Init()
        {
            Console.Write("Please enter an integer value: ");
            try
            {
                val = (int)uint.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                throw new Exception("Please enter a valid value!"+ e.Message);
            }

        }

        //-------------------------------------------------------------
        int Calculate()
        {
            fact = 1;
            for (int i = 1; i <= val; i++)
            {
                fact *= i;
            }
            return fact;
        }

        //-------------------------------------------------------------
        int val;
        int fact;
    }
}
