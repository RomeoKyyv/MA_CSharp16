using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes { UAH, USD, EU }

    public static class RateCurrencies
    {
        public static double rateUAH = 1;
        public static double rateUSD = 8;
        public static double rateEU = 10;
    }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public double Amount { get; set; }
        public CurrencyTypes? CurrencyType { get; set; }
        public double CurrentRate { get; set; }

        // 3) declare parameter constructor for properties initialization
        public Money(double amount, CurrencyTypes currencyType, double currentRate)
        {
            this.Amount = amount;
            this.CurrencyType = currencyType;
            this.CurrentRate = currentRate;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money money1, Money money2)
        {
            double currentRate = GetCurrentRateCurrency(money1);

            money1.Amount = money1.Amount + (money2.Amount * money2.CurrentRate / currentRate);

            return money1;
        }
        public static Money operator +(Money money1, double amountPlus)
        {
            double currentRate = GetCurrentRateCurrency(money1);

            money1.Amount = money1.Amount + (amountPlus * RateCurrencies.rateUAH / currentRate);

            return money1;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator -(Money money1, Money money2)
        {
            double currentRate = GetCurrentRateCurrency(money1);

            money1.Amount = money1.Amount - (money2.Amount * money2.CurrentRate / currentRate);

            return money1;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money money, int count)
        {
            if (count == 0)
                count = 3;
            return money.Amount * count;
        }
        public static Money operator /(Money money, int count)
        {
            if (count == 0)
                count = 2;

            return money.Amount / 3;
        }


        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money money1, Money money2)
        {
            double currentRate1 = GetCurrentRateCurrency(money1);
            double currentRate2 = GetCurrentRateCurrency(money2);

            double amountUAH1 = money1.Amount * money1.CurrentRate;
            double amountUAH2 = money2.Amount * money2.CurrentRate;

            return amountUAH1 > amountUAH2;
        }
        public static bool operator <(Money money1, Money money2)
        {
            double currentRate1 = GetCurrentRateCurrency(money1);
            double currentRate2 = GetCurrentRateCurrency(money2);

            double amountUAH1 = money1.Amount * money1.CurrentRate;
            double amountUAH2 = money2.Amount * money2.CurrentRate;

            return amountUAH1 < amountUAH2;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money money)
        {
            return money.CurrencyType != null;
        }
        public static bool operator false(Money money)
        {
            return money.CurrencyType == null;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static implicit operator double(Money money)
        {
            double currentRate = GetCurrentRateCurrency(money);
            return money.Amount * currentRate;
        }

        public static implicit operator Money(double amount)
        {
            return new Money(amount, CurrencyTypes.UAH, RateCurrencies.rateUAH);
        }

        public static implicit operator Money(string amountString)
        {
            if (double.TryParse(amountString, out double amount))
                return new Money(amount, CurrencyTypes.UAH, RateCurrencies.rateUAH);
            else
                new Exception("Error. Failed convert '" + amountString + "' to double.");

            return null;
        }

        public override string ToString()
        {
            return Convert.ToString(this);
            //double currentRate = GetCurrentRateCurrency(this);
            //return (Amount * currentRate).ToString();
        }



        private static double GetCurrentRateCurrency(Money money)
        {
            double currentRate;
            switch (money.CurrencyType)
            {
                case CurrencyTypes.UAH:
                    currentRate = RateCurrencies.rateUAH;
                    break;
                case CurrencyTypes.USD:
                    currentRate = RateCurrencies.rateUSD;
                    break;
                case CurrencyTypes.EU:
                    currentRate = RateCurrencies.rateEU;
                    break;
                default:
                    currentRate = RateCurrencies.rateUAH;
                    break;
            }
            return currentRate;
        }

    }
}
