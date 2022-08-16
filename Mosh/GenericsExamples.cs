using System;
using System.Collections.Generic;

namespace Mosh
{
	public class GenericsExamples
	{
		public void GenericsExamplesMain()
		{
			var book = new Book(new string[] { "1111", "Things about numbers by Nmbrfg" });

			var numbersList = new List<int>();
			numbersList.Add(11);

			var booksList = new BookList();
			booksList.Add(book);

			var numbersGenericsList = new GenericList<int>();
			numbersGenericsList.Add(22);

			var booksGenericsList = new GenericList<Book>();
			booksGenericsList.Add(new Book(new string[] { "1234", "Generic book" } ));
		}

		public class Book
		{
			private string _isbn;
			private string _title;
			public Book(string[] bookArray)
			{
				_isbn = bookArray[0];
				_title = bookArray[1];
			}
		}

		//Older non-generics way
		public class BookList
		{
			public void Add(Book book)
			{ throw new NotImplementedException(); }

			//Get book at index
			public Book this[int index]
			{ get { throw new NotImplementedException(); } }
		}

		//Newer 'Generics' way 
		public class GenericList<T> //'T' stands for type
		{
			public void Add(T genericValue)
			{ }

			//Get 'generic' at index
			public T this[int index]
			{ get { throw new NotImplementedException(); } }
		}
	}
}
