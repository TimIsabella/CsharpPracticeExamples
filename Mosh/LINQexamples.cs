using System;
using System.Collections.Generic;
using System.Linq;

namespace Mosh
{
	public class LINQexamples
	{
		public static void LINQexamplesMain()
		{
			Console.WriteLine("\n *********** LINQ EXAMPLES *********** \n");

			//LINQ - short for 'Language-Integrated Query'
			//A set of capabilities for querying different types of data:
			//- Memory objects and collections (LINQ to Objects)
			//- Databases (LINQ to Entities)
			//- XML (LINQ to XML)
			//- ADO.NET Data Sets (LINQ to Data Sets)

			/////////// OLD List<> way ///////////
			List<BookRepository.Book> allBooksList = new BookRepository().GetBooks();
			List<BookRepository.Book> cheapBooksList = new List<BookRepository.Book>();
			foreach(var book in allBooksList) if(book.Price < 10) cheapBooksList.Add(book);
			foreach(var book in cheapBooksList) Console.WriteLine($"Cheap Books from List<>: {book.Title} is ${book.Price}");

			/////////// NEW LINQ IEnumerable<> way ///////////
			//- IEnumerable acts the same as List<> and adds query extensions
			IEnumerable<BookRepository.Book> allBooksIEnumerable1 = new BookRepository().GetBooks();
			IEnumerable<BookRepository.Book> cheapBooksIEnumerable = new List<BookRepository.Book>();	//Adds LINQ query extensions
			cheapBooksIEnumerable = allBooksIEnumerable1.Where((bookElement) => bookElement.Price < 10);	//Using 'Where()' with lambda to List<> instead of foreach
			foreach(var book in cheapBooksIEnumerable) Console.WriteLine($"Cheap Books from IEnumerable<>: {book.Title} is ${book.Price}");

			/////////// LINQ Extension Methods ///////////

			//OrderBy()
			IEnumerable<BookRepository.Book> allBooksIEnumerable2 = new BookRepository().GetBooks();
			IEnumerable<BookRepository.Book> orderedBooksIEnumerable = allBooksIEnumerable2.OrderBy((bookElement) => bookElement.Title); //Using 'OrderBy()'
			foreach(var book in orderedBooksIEnumerable) Console.WriteLine($"Books ordered by title: {book.Title} is ${book.Price}");

			//Chaining Queries: .Where().OrderBy().Select()
			IEnumerable<BookRepository.Book> allBooksIEnumerable3 = new BookRepository().GetBooks();
			//Below is cast as a 'var' since the resulting IEnumerable<> queries changes it from a List of 'Book' object to a List of strings
			var chainedBooksIEnumerable = allBooksIEnumerable3.Where((bookElement) => bookElement.Price < 9)   //.Where()
															  .OrderBy((bookElement) => bookElement.Title)     //.OrderBy()
															  .Select((bookElement) => bookElement.Title);	   //.Select()
			
			foreach(var book in chainedBooksIEnumerable) Console.WriteLine($"Chained queries: {book}");

			/////////// LINQ Query Operators ///////////
			//- Just like T-SQL operators
			//- Below code is the same as above
			IEnumerable<BookRepository.Book> allBooksIEnumerable4 = new BookRepository().GetBooks();
			var cheaperBooks = from bookElement in allBooksIEnumerable4
							   where bookElement.Price < 9
							   orderby bookElement.Title
							   select bookElement.Title;

			foreach(var book in cheaperBooks) Console.WriteLine($"Chained queries by query operators: {book}");
		}

		public class BookRepository
		{
			public class Book
			{
				public string Title { get; set; }
				public float Price { get; set; }
			}

			//public IEnumerable<Book> GetBooks() //Method returns 'IEnumberable' of 'Book' object
			public List<Book> GetBooks() //Method returns 'List' of 'Book' object
			{
				List<Book> books = new List<Book>(); //Initialize List<Book>

				var book1 = new Book() { Title = "Book F", Price = 3.12f }; //Variable of 'Book' object initialized with data
				var book2 = new Book() { Title = "Book E", Price = 5.65f }; //Variable of 'Book' object initialized with data
				var book3 = new Book() { Title = "Book D", Price = 7.12f }; //Variable of 'Book' object initialized with data

				books.Add(book1); //'Book' object added to List<>
				books.Add(book2); //'Book' object added to List<>
				books.Add(book3); //'Book' object added to List<>
				books.Add(new Book() { Title = "Book C", Price = 9.34f });  //Variable of 'Book' object initialized with data and added to List<>
				books.Add(new Book() { Title = "Book B", Price = 11.11f }); //Variable of 'Book' object initialized with data and added to List<>
				books.Add(new Book() { Title = "Book A", Price = 22.22f }); //Variable of 'Book' object initialized with data and added to List<>

				return books;
			}
		}

		
	}
}
