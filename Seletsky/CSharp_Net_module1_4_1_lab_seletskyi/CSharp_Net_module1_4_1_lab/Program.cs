using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop shop = new OnlineShop();
            // 10) declare several objects of Customer
            Customer c1 = new Customer("Kon");
            Customer c2 = new Customer("Kon1");
            Customer c3 = new Customer("Kon2");
            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
           // shop.EvNewGood += c1.GotNewGoods;
            shop.EvNewGood += c3.GotNewGoods;

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            shop.NewGoods("Ball");
            Console.ReadLine();
        }
    }
}
