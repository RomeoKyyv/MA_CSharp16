using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes { UAH, USD, EU }

    class Money
    {
       public static double k_uan;
       public static double k_eu;
       static Money() {
           k_uan = 26.0;
           k_eu = 0.9;
       }
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set;  }
        public CurrencyTypes CurrencyType { get; set; }
        // 3) declare parameter constructor for properties initialization
        public Money():this(0,CurrencyTypes.USD){}
        public Money(decimal ch_1, CurrencyTypes ch_2) {
            this.Amount = ch_1;
            this.CurrencyType = ch_2;
        
        }
        public double Currency_uah() {
            if (this.CurrencyType == CurrencyTypes.EU) return 0.0;
            else if (this.CurrencyType == CurrencyTypes.USD) return (double)this.Amount *  k_uan;

            else return (double) this.Amount;

        }
        public double Currency_usd()
        {

            if (this.CurrencyType == CurrencyTypes.EU) return 0.0;
            else if (this.CurrencyType == CurrencyTypes.UAH) return (double)this.Amount / k_uan;

            else return (double)this.Amount;

        }
        public double Currency_eu()
        {
            if (this.CurrencyType == CurrencyTypes.USD) return 0.0;
            else if (this.CurrencyType == CurrencyTypes.UAH) return (double)this.Amount * k_uan;

            else return (double)this.Amount;
            

        }

        // 4) declare overloading of operator + to add 2 objects of Money
        static public Money operator + (Money ch_1, Money ch_2){

            if (ch_1.CurrencyType == ch_2.CurrencyType) return new Money(ch_1.Amount + ch_2.Amount, ch_1.CurrencyType);
            
            
            
            else {
                Console.WriteLine("CurrencyType is not corectly!");
                return new Money();
            }
        }
        // 5) declare overloading of operator -- to decrease object of Money by 1
        static public Money operator - (Money ch_1, Money ch_2){

            if (ch_1.CurrencyType == ch_2.CurrencyType) return new Money(ch_1.Amount - ch_2.Amount, ch_1.CurrencyType);
            else {
                Console.WriteLine("CurrencyType is not corectly!");
                return new Money();
            }
        }
            static public Money operator -- (Money ch_1){

             return new Money(ch_1.Amount --, ch_1.CurrencyType);
           
            }

            static public Money operator ++(Money ch_1)
            {

                return new Money(ch_1.Amount++, ch_1.CurrencyType);

            }
        // 6) declare overloading of operator * to increase object of Money 3 times
            static public Money operator *(Money ch_1, Money ch_2)
            {

                if (ch_1.CurrencyType == ch_2.CurrencyType) return new Money(ch_1.Amount * ch_2.Amount, ch_1.CurrencyType);
                else
                {
                    Console.WriteLine("CurrencyType is not corectly!");
                    return new Money();
                }
            }

                // 7) declare overloading of operator > and < to compare 2 objects of Money
            static public bool operator >(Money ch_1, Money ch_2)
            {

                if (ch_1.CurrencyType == ch_2.CurrencyType && ch_1.Amount > ch_2.Amount) return true;
                else if(ch_1.CurrencyType == ch_2.CurrencyType && ch_1.Amount < ch_2.Amount) return false;
                else {
                    Console.WriteLine("CurrencyType is not corectly!");
                    return false;
                }
            }
                    static public bool operator <(Money ch_1, Money ch_2)
            {

                if (ch_1.CurrencyType == ch_2.CurrencyType && ch_1.Amount < ch_2.Amount) return true;
                else if(ch_1.CurrencyType == ch_2.CurrencyType && ch_1.Amount > ch_2.Amount) return false;
                else {
                    Console.WriteLine("CurrencyType is not corectly!");
                    return false;
                }
            }
                // 8) declare overloading of operator true and false to check CurrencyType of object

                // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
            static public  explicit operator double (Money ch1){

                return (double)ch1.Amount;
    }
            static public explicit operator int(Money ch1)
            {

                return (int)ch1.Amount;
            }
            static public explicit operator string(Money ch1)
            {

                return ch1.Amount.ToString();
            } 
            }
    }


