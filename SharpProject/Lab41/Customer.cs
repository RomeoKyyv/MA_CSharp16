using System;

namespace SharpProject.Properties
{
    public class Customer
    {
        private string name;


        public Customer(string name, OnlimeShop shop)
        {
            this.name = name;
            shop.ShopEvent += this.GotNewGoods;
        }

        public void GotNewGoods(object type, ShopGoodsEventArgs eventArgs)
        {
            Console.WriteLine("Dear " + name + "we have " + eventArgs.getGoodsName() + " available now!");
        }
    }
}