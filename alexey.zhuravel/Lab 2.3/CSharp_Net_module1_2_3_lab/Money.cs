using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab

{ 
    public enum CurrencyTypes { UAH, USD, EUR}

    class Money
    {
        public Money(double amount, CurrencyTypes currencyType)
        {
            this.Amount = amount;
            this.CurrencyType = currencyType;
        }

        //-------------------------------------------------------------
        public static Money operator + (Money money1, Money money2)
        {
            CurrencyTypes currencyTypeOfTwoObjects = GetCurrencyOfTwoObjects(money1, money2);
            double ratio = ConvertionRatio(money1.GetCurrency(), money2.GetCurrency());

            return new Money(money1.Amount + money2.Amount * ratio, currencyTypeOfTwoObjects);            
        }

        //-------------------------------------------------------------
        public static Money operator - (Money money1, Money money2)
        {
            CurrencyTypes currencyTypeOfTwoObjects = GetCurrencyOfTwoObjects(money1, money2);
            double ratio = ConvertionRatio(money1.GetCurrency(), money2.GetCurrency());

            return new Money(money1.Amount - money2.Amount * ratio, currencyTypeOfTwoObjects);
        }

        //-------------------------------------------------------------
        public static Money operator -- (Money money)
        {
            return new Money(money.Amount - 1, money.CurrencyType);
        }
        //-------------------------------------------------------------
        static CurrencyTypes GetCurrencyOfTwoObjects(Money money1, Money money2)
        {            
            return money1.CurrencyType;
        }

        //-------------------------------------------------------------
        static double ConvertionRatio(CurrencyTypes currencyType1, CurrencyTypes currencyType2)
        {
            if (currencyType1 == CurrencyTypes.EUR)
            {            
                switch(currencyType2)
                {            
                    case CurrencyTypes.EUR:
                        return 1;
                    case CurrencyTypes.UAH:
                        return 1 / EURrate;
                    case CurrencyTypes.USD:
                        return USDrate/EURrate;
                    default:
                        throw new Exception("Unknown currency!");
                }
            }

            if (currencyType1 == CurrencyTypes.UAH)
            {
                switch (currencyType2)
                {
                    case CurrencyTypes.EUR:
                        return EURrate;
                    case CurrencyTypes.UAH:
                        return 1;
                    case CurrencyTypes.USD:
                        return USDrate;
                    default:
                        throw new Exception("Unknown currency!");
                }
            }

            if (currencyType1 == CurrencyTypes.USD)
            {
                switch (currencyType2)
                {
                    case CurrencyTypes.EUR:
                        return EURrate/USDrate;
                    case CurrencyTypes.UAH:
                        return USDrate;
                    case CurrencyTypes.USD:
                        return 1;
                    default:
                        throw new Exception("Unknown currency!");
                }
            }
            throw new Exception("Unknown currency!");
        }

        //-------------------------------------------------------------
        public void Print()
        {
            Console.WriteLine(Amount + " " + GetCurrency().ToString());
        }

        //-------------------------------------------------------------
        CurrencyTypes GetCurrency()
        {
            return this.CurrencyType;
        }

        //-------------------------------------------------------------
        public double               Amount { get; set; }

        public CurrencyTypes        CurrencyType { get; set; }
        const double                USDrate = 26.5;
        const double                EURrate = 29.4;

    }

    
}


// 1) declare enumeration CurrencyTypes, values UAH, USD, EU

// 2) declare 2 properties Amount, CurrencyType

// 3) declare parameter constructor for properties initialization

// 4) declare overloading of operator + to add 2 objects of Money

// 5) declare overloading of operator -- to decrease object of Money by 1

// 6) declare overloading of operator * to increase object of Money 3 times

// 7) declare overloading of operator > and < to compare 2 objects of Money

// 8) declare overloading of operator true and false to check CurrencyType of object

// 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa