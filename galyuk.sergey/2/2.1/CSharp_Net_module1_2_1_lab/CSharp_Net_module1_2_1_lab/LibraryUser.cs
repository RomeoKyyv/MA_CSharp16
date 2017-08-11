using System;

namespace CSharp_Net_module1_2_1_lab
{
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    public interface ILibraryUser
    {
        void AddBook(string nameBook);
        void RemoveBook(string nameBook);
        void BookInfo();
        int BooksCount();
    }

    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get; }
        public string LastName { get; }
        public string ID { get; }
        public string Phone { get; set; }
        public int BookLimit { get; }

        // 4) declare field (bookList) as a string array
        string[] bookList = new string[150];


        public dynamic mt(ref object a, out int b)
        {
            b = 0;
            dynamic i = 0;
            return i;
        }

        // 5) declare indexer BookList for array bookList
        public string this[int idBook]
        {
            get
            {
                return bookList[idBook];
            }
            set
            {
                bookList[idBook] = value;
            }
        }

        // 6) declare constructors: default and parameter
        public LibraryUser()
        {

        }
        
        public LibraryUser(string _FirstName, string _LastName, string _Phone, int _BookLimit)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Phone = _Phone;
            BookLimit = _BookLimit;
        }

        // 7) declare methods: 

        //AddBook() – add new book to array bookList
        public void AddBook(string nameBook)
        {
            //bookList;
        }

        //RemoveBook() – remove book from array bookList
        public void RemoveBook(string nameBook)
        {

        }

        //BookInfo() – returns book info by index
        public void BookInfo()
        {

        }

        //BooksCout() – returns current count of books
        public int BooksCount()
        {

            //MyClass mObj4 = new MyClass { MyProperty = 10 };
            //MyClass mObj1 = new MyClass();
            //MyClass mObj2 = new MyClass(6);
            //MyClass mObj5 = new MyClass(5) { MyProperty = 10 };
            //MyClass mObj3 = new MyClass() { MyProperty = 5 };
            //MyClass mObj6 = mObj2;


            //Method(a: 5);
            //Method(4); 
            //Method(b: "New String", a: 5); 

            return bookList.Length;
        }


    }

    //public class MyClass

    //{

    //    public int MyProperty { get; set; }

    //    public MyClass() { MyProperty = 0; }

    //    public MyClass(int prop) { MyProperty = prop; }

    //    public void Method(int a, string b = "Empty") { }

    //}

}
