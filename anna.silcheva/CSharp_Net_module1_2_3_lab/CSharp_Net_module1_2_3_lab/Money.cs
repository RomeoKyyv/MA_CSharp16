using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes { UAH, USD, EU };

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        double Amount { set; get; }
        CurrencyTypes CurrencyType { set; get; }
        // 3) declare parameter constructor for properties initialization
        public Money(double Amount, CurrencyTypes CurrencyType)
        {
            this.Amount = Amount;
            this.CurrencyType = CurrencyType;
        }
        public double  Course(Money Money1, Money Money2)
         {
            double crossCourse;
            if (Money1.CurrencyType == CurrencyTypes.UAH)
            {
                switch (Money2.CurrencyType)
                {
                    case CurrencyTypes.UAH:
                        crossCourse = 1;
                        break;
                    case CurrencyTypes.USD:
                        crossCourse = 25.8897;
                        break;
                    case CurrencyTypes.EU:
                        crossCourse = 0.0331;
                        break;
                    default:
                        crossCourse = 1;
                        break;

                }
                return crossCourse;
            }
            else if (Money1.CurrencyType == CurrencyTypes.USD)
            {
                switch (Money2.CurrencyType)
                {
                    case CurrencyTypes.UAH:
                        crossCourse = 0.0386;
                        break;
                    // return crossCourse;
                    case CurrencyTypes.USD:
                        crossCourse = 1;
                        break;
                    // return crossCourse;
                    case CurrencyTypes.EU:
                        crossCourse = 0.8589;
                        break;
                    // return crossCourse;
                    default:
                        crossCourse = 1;
                        break;
                        // return crossCourse;
                }
                return crossCourse;
            }
            else if (Money1.CurrencyType == CurrencyTypes.EU)
            {
                switch (Money2.CurrencyType)
                {
                    case CurrencyTypes.UAH:
                        crossCourse = 30.1408;
                        break;
                    case CurrencyTypes.USD:
                        crossCourse = 1.1642;
                        break;
                    case CurrencyTypes.EU:
                        crossCourse = 1;
                        break;
                    default:
                        crossCourse = 1;
                        break;
                }
                return crossCourse;
            }
            else
                return crossCourse = 0;
        }
        


    // 4) declare overloading of operator + to add 2 objects of Money
    public static Money operator +(Money Amount1, Money Amount2)
        {
            double c = Amount1.Course(Amount1, Amount2);
            return new Money(Amount1.Amount + Amount2.Amount*c, Amount1.CurrencyType);
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money Amount1)
        {
            return new Money((Amount1.Amount - 1), Amount1.CurrencyType);
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money Amount1, int counter)
        {
            //unter = 3;
            return new Money((Amount1.Amount * counter), Amount1.CurrencyType);
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money Amount1, Money Amount2)
        {
            double c = Amount1.Course(Amount1, Amount2);
            bool compare1 = Amount1.Amount > (Amount2.Amount*c);
            return compare1;
        }
        public static bool operator <(Money Amount1, Money Amount2)
        {
            double c = Amount1.Course(Amount1, Amount2);
            bool compare2 = Amount1.Amount < (Amount2.Amount * c);
            return compare2;
        }
        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money Amount1)
        {
            if ((Amount1.CurrencyType == CurrencyTypes.EU) || (Amount1.CurrencyType == CurrencyTypes.UAH) || (Amount1.CurrencyType == CurrencyTypes.USD))
            { return true; }
            else
                return false;
        }
        public static bool operator false(Money Amount1)
        {
            if ((Amount1.CurrencyType != CurrencyTypes.EU) || (Amount1.CurrencyType != CurrencyTypes.UAH) || (Amount1.CurrencyType != CurrencyTypes.USD))
            { return false; }
            else
                return true;
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Amount, this.CurrencyType);
        }
        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static explicit operator Money(double amount)
        {
            Money money = new Money(amount, CurrencyTypes.UAH);
            return money;
        }
        public static explicit operator double(Money amount)
        {
            double aa = amount.Amount;
            return aa;
        }
        public static implicit operator string(Money money1)
        {
            string a = Convert.ToString(money1.Amount);
            return a;
        }
        public static implicit operator Money(string a)
        { Money aa = new Money(Convert.ToDouble(a), CurrencyTypes.USD);
            return aa;
        }

    }
}
