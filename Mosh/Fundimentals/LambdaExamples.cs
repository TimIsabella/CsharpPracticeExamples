using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class LambdaExamples
	{
		public static void LambdaExamplesMain()
		{
			Console.WriteLine("\n *********** LAMBDA EXAMPLES *********** \n");

			Console.WriteLine(Multiply(1, 2, 3));

			//Same as above using lambda
			//'Func' delagate
			Func<int, int, int, int> multiplyByDelegate1 = (num1, num2, num3) => num1 * num2 * num3;
			Console.WriteLine(multiplyByDelegate1(1, 2, 3));

			const int number2 = 2;
			Func<int, int, int> multiplyByDelegate2 = (num1, num3) => num1 * number2 * num3;
			Console.WriteLine(multiplyByDelegate2(1, 3));

			/////////// Book Repository ///////////
			var books = new BookRepository().GetBooks();

			//Using a method
			var cheapBooks1 = books.FindAll(BookRepository.IsCheaperThan10Dollars);
			foreach(var book in cheapBooks1)
			{ Console.WriteLine($"By method: Cheap books under $10: {book.Title}"); }

			//Lambda method
			var cheapBooks2 = books.FindAll((book) => book.Price < 10);
			foreach(var book in cheapBooks2)
			{ Console.WriteLine($"By lambda: Cheap books under $10: {book.Title}"); }
		}

		public static int Multiply(int num1, int num2, int num3)
		{ return num1 * num2 * num3; }

		//////////////////////////////////////////////////////////////////

		public class BookRepository
		{
			//'Predicate method' - takes in value and returns true or false
			public static bool IsCheaperThan10Dollars(Book book)
			{ return book.Price < 10; }
			
			public class Book
			{
				public string Title;
				public int Price;
			}

			public List<Book> GetBooks()
			{
				return new List<Book>
				{
					new Book() {Title = "Title 1", Price = 3},
					new Book() {Title = "Title 2", Price = 7},
					new Book() {Title = "Title 3", Price = 17}
				};
			}
		}
	}
}
