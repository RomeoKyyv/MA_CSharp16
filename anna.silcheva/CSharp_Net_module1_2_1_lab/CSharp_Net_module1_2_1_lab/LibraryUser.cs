using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Net_module1_2_1_lab
{

	// 1) declare interface ILibraryUser
	// declare method's signature for methods of class LibraryUser

	interface ILibraryUser
	{
		void AddBook();

		void RemoveBook();

		void BookInfo();

		void BooksCout();
	}

	// 2) declare class LibraryUser, it implements ILibraryUser
	class LibraryUser : ILibraryUser
	{
		public string FirstName { get; }
		public string LastName { get; }
		public int Id { get; }
		public string Phone { get; set; }
		public int BookLimit { get; }
		string [] bookList;
		public string this[int BookList]
		{
			set
			{
				bookList[BookList] = value;
			}
			get
			{
				return bookList[BookList];
			}
		}
		public LibraryUser()
		{
		}

		public LibraryUser(string FirstName, string LastName, string Phone, int BookLimit)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Phone = Phone;
			this.BookLimit = BookLimit;
		}
		public void AddBook()
		{
		}

		public void RemoveBook()
		{
		}

		public void BookInfo()
		{
		}

		public void BooksCout()
		{
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
