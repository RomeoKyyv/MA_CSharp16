using System.Collections.Generic;

namespace SharpProject.Lab53
{
    public class Customer
    {
    }

    public class Product
    {
        public string Name;
        public double Price;
    }

    public class Order
    {
        public int OrderId;
        public Product Product;
        public int Qty;
    }

    public class OrderList
    {
        public Order Order;
        public int Id;
    }

    public class SupplierList
    {
        public string Name;
        public string Phone;
    }
}