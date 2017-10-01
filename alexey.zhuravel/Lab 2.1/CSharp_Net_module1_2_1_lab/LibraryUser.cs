using System;

namespace CSharp_Net_module1_2_1_lab
{
    // 5) declare indexer BookList for array bookList

    interface ILibraryUser
    {
        void AddBook(string BookName);
        void RemoveBook(string BookName);
        void BooksInfo();
        int BooksCount();
    }

    //-------------------------------------------------------------
    class LibraryUser : ILibraryUser
    {
        public LibraryUser()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.BookLimit = 20;
        }

        //-------------------------------------------------------------
        public LibraryUser(string FirstName, string LastName, string Phone, int BookLimit)
        {
            this.FirstName = FirstName;
            this.LastName= LastName;
            this.Phone = Phone;
            this.BookLimit = BookLimit;
        }

        //-------------------------------------------------------------
        public void AddBook(string BookName)
        {

        }

        //-------------------------------------------------------------
        public void RemoveBook(string BookName)
        {

        }

        //-------------------------------------------------------------
        public void BooksInfo()
        {

        }

        //-------------------------------------------------------------
        public int BooksCount()
        {
            return 0;
        }

        //-------------------------------------------------------------
        public int this[int index]
        {
            set { Indexer[index] = value; }
            get { return Indexer[index]; }
        }        

        //-------------------------------------------------------------
        public string                  FirstName { get; }
        public string                  LastName { get; }
        public int                     Id { get; }
        public string                  Phone { get; set; }
        public int                     BookLimit { get; set; }
        public string[]                BookList { get; set; }
        public int[]                   Indexer { get; set; }
    }



    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    // 2) declare class LibraryUser, it implements ILibraryUser
    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)

    // 4) declare field (bookList) as a string array




    // 6) declare constructors: default and parameter

    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books

}
