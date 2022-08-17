﻿using System;
using System.Collections.Generic;

namespace Mosh
{
	public class LambdaExamples
	{
		public void LambdaExamplesMain()
		{
			Console.WriteLine("\n *********** LAMBDA EXAMPLES *********** \n");

			Console.WriteLine(Multiply(123, 456, 789));

			//Same as above using lambda
			//'Func' delagate
			Func<int, int, int, int> multiplyByDelegate1 = (num1, num2, num3) => num1 * num2 * num3;
			Console.WriteLine(multiplyByDelegate1(123, 456, 789));

			const int number2 = 456;
			Func<int, int, int> multiplyByDelegate2 = (num1, num3) => num1 * number2 * num3;
			Console.WriteLine(multiplyByDelegate2(123, 789));
		}

		public static int Multiply(int num1, int num2, int num3)
		{
			return num1 * num2 * num3;
		}

		//////////////////////////////////////////////////////////////////

		public class BookRepository
		{
			public class Book
			{
				public string Title { get; set; }
				public int Price { get; set; }
			}

			public List<Book> GetBooks()
			{
				return new List<Book>
				{
					new Book() {Title = "Title 1", Price = 3},
					new Book() {Title = "Title 2", Price = 5},
					new Book() {Title = "Title 3", Price = 7}
				};
			}
		}
	}
}
