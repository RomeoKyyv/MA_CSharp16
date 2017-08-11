using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

    interface ILibaryUser {
        void AddBook(string name);
        void RemoveBook(int id, string info);
        void Bookinfo();
        void BooksCount();
    }

    // 2) declare class LibraryUser, it implements ILibraryUser

    class LibaryUser : ILibaryUser { 
        private string firstName;
        private string lastName;
        private int id;
        private int iddu;
        private int phone;
        private int bookLimit;
        private string[] bookList;

        public string FirstName {
            get { return firstName; }
        }

        public string LastName {
            get { return lastName; }
        }

        public int Id {
            get { return iddu; }
        }

        public int Phone {
            get { return phone; }
        }

        public int BookLimit {
            get { return bookLimit; }
        }

        public string this[int index] {
            get { return bookList[index]; }
            set
            {
                if (id== index && index < bookLimit)
                {
                    bookList[index] = value;
                    id++;
                }
                else { Console.WriteLine("No!"); }
            }
        
        }

        public LibaryUser(string firstn, string lastn, int idu, int phone, int booklimit) {
            this.firstName = firstn;
            this.lastName = lastn;
            this.iddu = idu;
            this.phone = phone;
            this.bookLimit = booklimit;
            id = 0;
            bookList= new string[booklimit];

        
        }
        public void AddBook(string name) {
            this[id] = name;
        }
        public void RemoveBook(int id,string name) {
            if (id >= 0 && id < bookLimit)
            {
                bookList[id] = name;
            }
            else { Console.WriteLine("Error!"); }
        }
        public void Bookinfo() {
            foreach (string ch in bookList) {
                Console.WriteLine(ch);
            }
        }
        public void BooksCount() {
            Console.WriteLine("Hello");
        }
    }
    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)
 
    // 4) declare field (bookList) as a string array

 
    // 5) declare indexer BookList for array bookList
 
    // 6) declare constructors: default and parameter
 
    // 7) declare methods: 

        //AddBook() – add new book to array bookList
 
        //RemoveBook() – remove book from array bookList
 
        //BookInfo() – returns book info by index
 
        //BooksCout() – returns current count of books
  
}
