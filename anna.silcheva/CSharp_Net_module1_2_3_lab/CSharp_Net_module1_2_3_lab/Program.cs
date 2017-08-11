using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            // 11) do operations
            // add 2 objects of Money

            // add 1st object of Money and double

            // decrease 2nd object of Money by 1 

            // increase 1st object of Money
            // compare 2 objects of Money
            // compare 2nd object of Money and string
            //check CurrencyType of every object
            // convert 1st object of Money to string
            Money Money1 = new Money(5, CurrencyTypes.EU);
            Money Money2 = new Money(6.0, CurrencyTypes.UAH);
            Console.WriteLine("[{0}]", Money1 + Money2);
            Console.WriteLine("[{0}]", Money2--);
            Console.WriteLine("[{0}]", Money1 * 3);
            Console.WriteLine("[{0}]", Money1 > Money2);
            if (Money1)
            {
                Console.WriteLine("true");
            }
            else
            { Console.WriteLine("false"); }
            if (Money2)
            {
                Console.WriteLine("true");
            }
            else
            { Console.WriteLine("false"); }
            double a = 5;
            Money aa = (Money)a;
            Console.WriteLine(aa);
            double ab = (double)Money1;
            Console.WriteLine(ab);
            string ac = Money1;
            Console.WriteLine(ac);
            string n = "500";
            Money nn = n;
            Console.WriteLine(aa);
            Console.ReadKey();
        }
    }
}
