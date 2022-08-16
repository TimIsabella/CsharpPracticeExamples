using System;
using System.Collections.Generic;

namespace Mosh
{
	public class GenericsExamples
	{
		public static void GenericsExamplesMain()
		{
			Console.WriteLine("\n *********** GENERICS *********** \n");

			var book = new Book(new string[] { "111", "This book" });
			Console.WriteLine($"Book ISBN: {book.Isbn}, Book Title: {book.Title}");

			var numList = new List<int>();
			numList.Add(11); numList.Add(22); numList.Add(33);
			Console.WriteLine($"numList [0]={numList[0]}, [1]={numList[1]}, [2]={numList[2]}");

			var numGenericList = new GenericList<int>();
			numGenericList.Add(33); numGenericList.Add(66); numGenericList.Add(99);
			Console.WriteLine($"numGenericList [0]={numGenericList[0]}, [1]={numGenericList[1]}, [2]={numGenericList[2]}");

			var booksGenericsList = new GenericList<Book>();
			booksGenericsList.Add(new Book(new string[] { "222", "Generic book" }));
			Console.WriteLine($"booksGenericsList ISBN: {booksGenericsList[0].Isbn}, Book Title: {booksGenericsList[0].Title}");

			var genericBookDictionary = new GenericsDictionary<string, Book>();
			genericBookDictionary.AddToDictionary("11", new Book(new string[] { "333", "Dictionary book" }));
			Console.WriteLine($"Entry '11' book title is '{genericBookDictionary["11"].Title}'");
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
			public string Title { get { return _title; } }
			public string Isbn { get { return _isbn; } }
		}

		public class GenericList<T> //'T' stands for type
		{
			private T _genericValue;
			public void Add(T genericValue)
			{ _genericValue = genericValue; }

			//Indexer - Get value of 'this' generic list at 'index'
			public T this[int index]
			{ get { return _genericValue; } }
		}

		public class GenericsDictionary<TKey, TValue>
		{
			private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

			public void AddToDictionary(TKey key, TValue value)
			{
				_dictionary.Add(key, value);
			}

			public TValue this[TKey key]
			{ get { return _dictionary[key]; } }
		}

		//
		public class GenericsNumberProcessing<T> where T : IComparable
		{
			public T ReturnMaxNumber(T num1, T num2)
			{
			    //If 'T num1' is greater than 'T num2', result will be 0
				if(num1.CompareTo(num2) > 0) return num1;
				else return num2;
			}
		}
	}
}
