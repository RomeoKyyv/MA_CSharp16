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

            Console.WriteLine("Current currency rate:");
            Console.WriteLine("USD: {0}", RateCurrencies.rateUSD);
            Console.WriteLine("EU: {0}", RateCurrencies.rateEU);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Enter amount UAH:");
            double amountUAH = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount USD:");
            double amountUSD = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount EU:");
            double amountEU= double.Parse(Console.ReadLine());

            // 10) declare 2 objects
            Money UAH = new Money(amountUAH, CurrencyTypes.UAH, RateCurrencies.rateUAH);
            Money USD = new Money(amountUSD, CurrencyTypes.USD, RateCurrencies.rateUSD);
            Money EU = new Money(amountEU, CurrencyTypes.EU, RateCurrencies.rateEU);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Choice of action:");
            Console.WriteLine("1 - add 2 objects of Money");
            Console.WriteLine("2 - add 1st object of Money and double (in developing)");
            Console.WriteLine("3 - decrease 2nd object of Money by 1 ");
            Console.WriteLine("4 - increase 1st object of Money");
            Console.WriteLine("5 - compare 2 objects of Money");
            Console.WriteLine("6 - compare 2nd object of Money and string (in developing)");
            Console.WriteLine("7 - check CurrencyType of every object");
            Console.WriteLine("8 - convert 1st object of Money to string");
            Console.WriteLine("--------------------------------------------");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:

                    #region add 2 objects of Money

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("EU: {0}, {1}", EU.Amount, EU.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH + USD");
                    UAH += USD;
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("USD + EU");
                    USD += EU;
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    break;

                    #endregion

                case 2:

                    #region add 1st object of Money and double

                    break;

                    #endregion

                case 3:

                    #region decrease 2nd object of Money by 1 

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("EU: {0}, {1}", EU.Amount, EU.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("USD - UAH");
                    UAH -= USD;
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("EU - USD");
                    USD -= EU;
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    break;

                    #endregion

                case 4:

                    #region increase 1st object of Money
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Enter amount UAH:");
                    double amountPlus = double.Parse(Console.ReadLine());

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("EU: {0}, {1}", EU.Amount, EU.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH + {0}", amountPlus);
                    UAH += amountPlus;
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("USD + {0}", amountPlus);
                    USD += amountPlus;
                    Console.WriteLine("UAH: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("EU + {0}", amountPlus);
                    EU += amountPlus;
                    Console.WriteLine("UAH: {0}, {1}", EU.Amount, EU.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    break;

                    #endregion

                case 5:

                    #region compare 2 objects of Money

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH: {0}, {1}", UAH.Amount, UAH.CurrentRate);
                    Console.WriteLine("USD: {0}, {1}", USD.Amount, USD.CurrentRate);
                    Console.WriteLine("EU: {0}, {1}", EU.Amount, EU.CurrentRate);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("UAH > USD");
                    bool result = UAH > USD;
                    Console.WriteLine("Result: {0}", result.ToString());
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("EU > USD");
                    result = EU > USD;
                    Console.WriteLine("Result: {0}", result.ToString());
                    Console.WriteLine("--------------------------------------------");

                    break;

                    #endregion

                case 6:

                    #region compare 2nd object of Money and string

                    break;

                    #endregion

                case 7:

                    #region check CurrencyType of every object

                    Console.WriteLine("currency type UAH = null? - {0}", UAH);
                    Console.WriteLine("currency type USD = null? - {0}", USD);
                    Console.WriteLine("currency type EU = null? - {0}", EU);
                    break;

                    #endregion

                case 8:

                    #region convert 1st object of Money to string

                    Console.WriteLine("UAH to string: {0}", UAH.ToString());
                    Console.WriteLine("USD to string: {0}", USD.ToString());
                    Console.WriteLine("EU to string: {0}", EU.ToString());
                    break;

                    #endregion

            }

            Console.ReadLine();

        }
    }
}
