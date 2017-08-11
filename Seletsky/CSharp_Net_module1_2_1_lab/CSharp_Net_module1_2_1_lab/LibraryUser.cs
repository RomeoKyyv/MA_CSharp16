using System;

namespace CSharp_Net_module1_2_1_lab
{
    /* public struct bookinfo_type { string BookName;
     string Author;
     }
  */
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    public interface ILibraryUser
    {
        bool AddBook();
        bool RemoveBook();
        //   bookinfo_type BookInfo();
        string BookInfo();
        int BooksCount();
    }


    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        string firstname;
        string lastname;
        int id;
        string phone;
        int booklimit;
        int pointbooklist;
        const int MaxBookLimit = 100;
        public string FirstName
        {
            get { return firstname; }
        }
        public string LastName
        {
            get { return lastname; }
        }

        public int Id
        {
            get { return id; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public int BookLimit
        {
            get { return booklimit; }

        }
        // 4) declare field (bookList) as a string array    Computer[,][] Comps = new Computer[DepatN,TypeCompN][];
        public string[] booklist = new string[MaxBookLimit];
        // need pointer for booklist
        public int Pointbooklist
        {
            get { return pointbooklist; }
            set { pointbooklist = value; }
        }

        // 5) declare indexer BookList for array bookList
        public string this[int ind_var]
        {

            get
            {
                //string set = "";
                return booklist[ind_var];
            }
            set
            {
                booklist[ind_var] = value;
            }
        }
        // 6) declare constructors: default and parameter
        public LibraryUser(string FN, string LN, string PN, int ID)
        {
            firstname = FN;
            lastname = LN;
            id = ID;
            phone = PN;
            pointbooklist = 0;
            booklimit = MaxBookLimit;
        }
        public LibraryUser()
        {
            firstname = "";
            lastname = "";
            id = 0;
            phone = "";
            pointbooklist = 0;
            booklimit = MaxBookLimit;
        }

        // 7) declare methods: 

        //AddBook() – add new book to array bookList
        public bool AddBook(string Abook)
        {
            int tmp;
            tmp = pointbooklist;
            booklist[tmp] = Abook;
            ++pointbooklist;
            return true;
        }
        //RemoveBook() – remove book from array bookList
        public bool RemoveBook(string Rbook)
        {
            int i = 0;
            while (booklist[i] != Rbook)
            {
                ++i;

            }
            booklist[i] = booklist[pointbooklist - 1];
            --pointbooklist;
            return true;
        }
        //BookInfo() – returns book info by index
        public string BookInfo() { return ""; }
        //BooksCout() – returns current count of books
        public int BooksCount() { return pointbooklist; }
    }
}
