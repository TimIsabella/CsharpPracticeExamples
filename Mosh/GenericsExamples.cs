using System;
using System.Collections.Generic;

namespace Mosh
{
	public class GenericsExamples
	{
		public static void GenericsExamplesMain()
		{
			Console.WriteLine("\n *********** GENERICS *********** \n");

			//Normal list -- instantiated to take integers
			var numList = new List<int>();
			numList.Add(11); numList.Add(22); numList.Add(33);
			Console.WriteLine($"numList -- [0]={numList[0]}, [1]={numList[1]}, [2]={numList[2]}");

			///////////

			//Generic list class -- instantiated to take bools
			var boolGenericList = new GenericClassList<bool>();
			boolGenericList.AddToList(true); boolGenericList.AddToList(false); boolGenericList.AddToList(true);
			Console.WriteLine($"boolGenericList -- [0]={boolGenericList[0]}, [1]={boolGenericList[1]}, [2]={boolGenericList[2]}");

			//Generic list class -- instantiated to take ints
			var numGenericList = new GenericClassList<int>();
			numGenericList.AddToList(33); numGenericList.AddToList(66); numGenericList.AddToList(99);
			Console.WriteLine($"numGenericList -- [0]={numGenericList[0]}, [1]={numGenericList[1]}, [2]={numGenericList[2]}");

			//Generic list class -- instantiated to take strings
			var stringGenericList = new GenericClassList<string>();
			stringGenericList.AddToList("This"); stringGenericList.AddToList("That"); stringGenericList.AddToList("Those");
			Console.WriteLine($"stringGenericList -- [0]={stringGenericList[0]}, [1]={stringGenericList[1]}, [2]={stringGenericList[2]}");

			///////////

			//Book class -- takes two string inputs
			var book = new Book(new string[] { "111", "This book" });
			Console.WriteLine($"Book -- ISBN: {book.Isbn}, Book Title: {book.Title}");

			//Generic list class -- instantiated to take Book classes
			var booksGenericsList = new GenericClassList<Book>();
			booksGenericsList.AddToList(new Book(new string[] { "222", "Generic book" }));
			Console.WriteLine($"booksGenericsList -- ISBN: {booksGenericsList[0].Isbn}, Book Title: {booksGenericsList[0].Title}");

			//Generic dictionary class -- instantiated to take Book classes with key value as string
			//- Dictionaries are indexed by key value
			var genericBookDictionary = new GenericDictionary<string, Book>();
			genericBookDictionary.AddToDictionary("11", new Book(new string[] { "333", "Dictionary book" }));
			Console.WriteLine($"genericBookDictionary -- Entry '11' book ISBN: '{genericBookDictionary["11"].Isbn}'");
			Console.WriteLine($"genericBookDictionary -- Entry '11' book title: '{genericBookDictionary["11"].Title}'");
		}

		//Book
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

		//List
		public class GenericClassList<T> //'T' stands for type
		{
			private T _genericValue;
			
			//Add to list
			public void AddToList(T genericValue) { _genericValue = genericValue; }

			//Indexer - Get value of 'this' generic list at 'index' value, and return 'T'
			public T this[int index] { get { return _genericValue; } }
		}

		//Dictionary
		public class GenericDictionary<TKey, TValue>
		{
			//Dictionaries take two inputs:
			// - Key: the position name within the dictionary
			// - Value: The value of that position
			private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

			//Add to dictionary
			public void AddToDictionary(TKey key, TValue value) { _dictionary.Add(key, value); }

			//Indexer - Get value of 'this' dictionary at 'TKey' value, and return 'TValue'
			public TValue this[TKey key] { get { return _dictionary[key]; } }
		}

		//////////////////////////////////////////////////////////////////

												
		public class GenericNumberProcessing<T> where T : IComparable	//Adds IComparable 'constraint' to T
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
