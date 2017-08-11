using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(fact(3));

            Console.ReadKey();
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator
        public static int fact (int N) {

            if (N < 0) // если пользователь ввел отрицательное число
                return 0; // возвращаем ноль
            if (N == 0) // если пользователь ввел ноль,
                return 1; // возвращаем факториал от нуля - не удивляетесь, но это 1 =)
            else // Во всех остальных случаях
                return N * fact(N - 1);
        
        }
    }

    

}
