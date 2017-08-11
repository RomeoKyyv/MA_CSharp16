using System;

namespace CSharp_Net_module1_2_1_lab
{

    class Program
    {
        static void Main(string[] args)
        {
            // 8) declare 2 objects. Use default and paremeter constructors
            LibaryUser user1 = new LibaryUser("Aleksandr","Pilipenko",998237,0937301547,5) , user2 = new LibaryUser("Maria", "Ivanenko",48594594 ,447777777, 2);
            Console.WriteLine("User1 " + user1.FirstName + " " + user1.LastName);
            Console.WriteLine ("User2 " + user2.FirstName + " " + user2.LastName);
                
            // 9) do operations with books for all users: run all methods for both objects
            user1.AddBook("Hary Potter");
            user2.AddBook("Imperializm");
            user1.AddBook("independent");
            user1.AddBook("independent"); user1.AddBook("independent"); user1.AddBook("independent"); user1.AddBook("independent");
            user1.Bookinfo();

            Console.ReadKey();
        }
    }
}
