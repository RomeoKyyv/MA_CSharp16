using SharpProject.Properties;

namespace SharpProject.Lab41
{
    public class Lab41Init
    {
        public Lab41Init()
        {
            OnlimeShop onlimeShop = new OnlimeShop("Shop 1: HP");
            OnlimeShop onlimeShop2 = new OnlimeShop("Shop 2: ASUS");

            Customer customer1 = new Customer("Franz", onlimeShop);
            Customer customer2 = new Customer("Karl", onlimeShop);
            Customer customer3 = new Customer("Rupert", onlimeShop2);
            Customer customer4 = new Customer("Ziegfried", onlimeShop2);

            onlimeShop.NewGoods();
            onlimeShop2.NewGoods();
        }
    }
}