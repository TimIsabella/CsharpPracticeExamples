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
			var boolGenericList = new GenericListClass<bool>();
			boolGenericList.AddToList(true); boolGenericList.AddToList(false); boolGenericList.AddToList(true);
			Console.WriteLine($"boolGenericList -- [0]={boolGenericList[0]}, [1]={boolGenericList[1]}, [2]={boolGenericList[2]}");

			//Generic list class -- instantiated to take ints
			var numGenericList = new GenericListClass<int>();
			numGenericList.AddToList(33); numGenericList.AddToList(66); numGenericList.AddToList(99);
			Console.WriteLine($"numGenericList -- [0]={numGenericList[0]}, [1]={numGenericList[1]}, [2]={numGenericList[2]}");

			//Generic list class -- instantiated to take strings
			var stringGenericList = new GenericListClass<string>();
			stringGenericList.AddToList("This"); stringGenericList.AddToList("That"); stringGenericList.AddToList("Those");
			Console.WriteLine($"stringGenericList -- [0]={stringGenericList[0]}, [1]={stringGenericList[1]}, [2]={stringGenericList[2]}");

			///////////

			//Book class -- takes two string inputs
			var book = new Book(new string[] { "111", "This book" });
			Console.WriteLine($"Book -- ISBN: {book.Isbn}, Book Title: {book.Title}");

			//Generic list class -- instantiated to take Book classes
			var booksGenericsList = new GenericListClass<Book>();
			booksGenericsList.AddToList(new Book(new string[] { "222", "Generic book" }));
			Console.WriteLine($"booksGenericsList -- ISBN: {booksGenericsList[0].Isbn}, Book Title: {booksGenericsList[0].Title}");

			//Generic dictionary class -- instantiated to take Book classes with key value as string
			//- Dictionaries are indexed by key value
			var genericBookDictionary = new GenericDictionaryClass<string, Book>();
			genericBookDictionary.AddToDictionary("11", new Book(new string[] { "333", "Dictionary book" }));
			Console.WriteLine($"genericBookDictionary -- Entry '11' book ISBN: '{genericBookDictionary["11"].Isbn}'");
			Console.WriteLine($"genericBookDictionary -- Entry '11' book title: '{genericBookDictionary["11"].Title}'");

			/////////// Generics Constraints ///////////
			var nullableNumber = new Nullable<int>(333);
			Console.WriteLine($"nullableNumber -- Has Value?: {nullableNumber.HasValue}");
			Console.WriteLine($"nullableNumber -- Value: {nullableNumber.GetValueOrDefault()}");

		}

		///////////////////////////////// Generics /////////////////////////////////

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

		//Generic List class -- specified by <> brackets
		public class GenericListClass<T> //'T' stands for generic type (T is not a reserved word)
		{
			private T _genericValue;
			
			//Add to list
			public void AddToList(T genericValue) { _genericValue = genericValue; }

			//Indexer - Get value of 'this' generic list at 'index' value, and return 'T'
			public T this[int index] { get { return _genericValue; } }
		}

		//Dictionary generic list class (two generic values)
		public class GenericDictionaryClass<TKey, TValue>
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

		///////////////////////////////// Applying constraints to generics /////////////////////////////////

		public class GenericConstraintsExamples
		{
			//Applying constraints to generics
			//"where T generic is a ..."
			//where T : IComparable
			//where T : Product
			//where T : struct
			//where T : class
			//where T : new()
			public class GenericConstraints<T> where T : IComparable //Adds IComparable 'constraint' to T
			{
				public T ReturnMaxNumber(T num1, T num2)
				{
					//If 'T num1' is greater than 'T num2', result will be 0
					if(num1.CompareTo(num2) > 0) return num1;
					else return num2;
				}
			}

			///////////

			//Provides value types to be nullable
			public class Nullable<T> where T : struct //'T' is cast as a struct
			{
				private object _value;
				public Nullable()
				{ }

				public Nullable(T value)
				{ _value = value; }
				
				public bool HasValue
				{ get { return _value != null; } } //Returns true if value, otherwise returns false

				public T GetValueOrDefault()
				{
					if(HasValue) return (T) _value;	//If 'HasValue' is true, return 'T' value
							else return default(T); //If 'HasValue' is false, return 'default' of 'T' value	
				}									//-- 'default' returns 'null' for reference types and '0' for value types when generic object is not initialized.
			}										//-- 'T' is cast as a struct (value type), therefore the return is '0'

			///////////

			public class Product
			{
				public string Title { get; set; }
				public float Price { get; set; }
			}

			public class Book : Product
			{ public string Isbn { get; set; } }

			public class DicountCalculator<TProduct> where TProduct : Product
			{
				public float CalculateDiscount(TProduct product)
				{ return product.Price; }
			}
		}


	}
}
