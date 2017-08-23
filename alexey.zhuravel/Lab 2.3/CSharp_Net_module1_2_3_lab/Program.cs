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
            Money m1 = new Money(2.2, CurrencyTypes.UAH);
            Money m2 = new Money(5.4, CurrencyTypes.EUR);

            Money m3 = m1+m2;

            m3.Print();
        }
    }
}
// 10) declare 2 objects

// 11) do operations
// add 2 objects of Money

// add 1st object of Money and double

// decrease 2nd object of Money by 1 

// increase 1st object of Money

// compare 2 objects of Money

// compare 2nd object of Money and string

// check CurrencyType of every object

// convert 1st object of Money to string