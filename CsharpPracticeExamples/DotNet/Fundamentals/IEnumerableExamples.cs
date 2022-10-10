using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples.DotNet.Fundamentals
{
	public class IEnumerableExamples
	{
		public static void IEnumerableExamplesMain()
		{
			Console.WriteLine("\n *********** IENUMERABLE EXAMPLES *********** \n");
			/// IEnumerable<T> is the base interface for ALL non-generic collections in .NET -- it is the basic support for iteration or traversing a collection
			///- Provides a simple way to enumerate the contents of a collection
			///- All .NET collection types (arrays, List<T>, etc.) implement IEnumerable<T>

			///LINQ
			///- IEnumerable<T> is the CENTRAL interface for LINQ operations
			///- Doses not have LINQ operators built in so must implement those operators with a 'Func<T>' argument -- known as 'LINQ to Objects'
			///- Since IEnumerable does not have LINQ built in, its process of LINQ operators is a 'deferres execution'
			///- The deferred execution is a major performance advantage by querying objects in memory AFTER the full query has been established
			///- The alternative would be to write multiple nested for loops and run the logic therein

			var para1 = new Params { A = 1, B = 2, C = 3 };					// All these are cast as 'IEnumerable<int>'
			Params para2 = new Params { A = 4, B = 5, C = 6 };              //
			IEnumerable<int> para3 = new Params { A = 7, B = 8, C = 9 };    //

			foreach(var p in para3)							//'foreach' only runs on collections exposed by 'IEnumerable'
			{ Console.WriteLine(p); }

			/// //////////////////////////////////////////////////////////////////

			var personYeild = new Person { Id = 3, Name = "Bill Williams", Location = "Texas" };

			foreach(var name in personYeild.Names)
			{ Console.WriteLine(name); }

			/// //////////////////////////////////////////////////////////////////

			var peopleList = new List<Person>() {
												     new Person { Id = 0, Name = "John Doe", Location = "California"},
													 new Person { Id = 1, Name = "Sarah Connor", Location = "Nevada"},
													 new Person { Id = 2, Name = "Jake Phillips", Location = "Florida"},
												};

			Person[] peopleArray = new[] {
										      new Person { Id = 0, Name = "John Doe", Location = "California"},
											  new Person { Id = 1, Name = "Sarah Connor", Location = "Nevada"},
											  new Person { Id = 2, Name = "Jake Phillips", Location = "Florida"},
										 };

			//'List' collection down casted to 'IEnumerable'
			//- 'List' is a higher form of 'IEnumerable'
			//- Converted using '.AsEnumerable()'
			IEnumerable<Person> peopleListEnumerable = peopleList.AsEnumerable();

			//Array converted and extended by 'IEnumerable'
			//- 'IEnumerable' extension methods can now be called on the array
			//- Direct conversion since it is compatible
			IEnumerable<Person> peopleArrayEnumerable = peopleArray;

			/// //////////////////////////////////////////////////////////////////

			//Returns an 'IQueryable'
			//- Whole object is returned
			var enumerableQuery1 = peopleListEnumerable.Where(person => person.Id == 1);

			///Below doesn't work because it is an 'IEnumerable' object
			//Console.WriteLine($" Person ID {enumerableQuery1.Id} = {enumerableQuery1.Name} is in {enumerableQuery1.Location}");

			//'foreach' is part of 'IEnumerable'
			foreach(Person person in enumerableQuery1)
			{ Console.WriteLine($"enumerableQuery1 -- Person ID {person.Id} = '{person.Name}' who lives in '{person.Location}'"); }

			//Returns an 'IEnumerable'
			//- Object string 'Name' is returned
			var enumerableQuery2 = from people
								   in peopleArrayEnumerable
								   where people.Id == 2
								   select people.Name;

			///Below doesn't work because it is an 'IEnumerable' string
			//Console.WriteLine($" Person ID 2 Name = '{enumerableQuery2.Name}'");

			//'foreach' is part of 'IEnumerable'
			foreach(string person in enumerableQuery2)
			{ Console.WriteLine($"enumerableQuery2 -- Person ID 2 Name = '{person}'"); }
		}

		///////////////////////////////////////////////////////////////////////////////////////////////////

		//'Params' implements 'IEnumerable' interface to support simple iteration over a collection (foreach functionality)
		public class Params : IEnumerable<int>
		{
			public int A, B, C;

			//When 'GetEnumerator()' is called, each 'yield' return is called one by one with the 'helper method' below
			public IEnumerator<int> GetEnumerator()
			{
				yield return A;
				yield return B;
				yield return C;
				yield return 7;
				yield return 8;
				yield return 9;
			}

			//'Helper method' used to call 'GetEnumerator()' which returns as an 'IEnumerator<int>'
			//- Executed once for each element in the collection
			IEnumerator IEnumerable.GetEnumerator()
			{ return GetEnumerator(); }
		}

		///////////////////////////////////////////////////////////////////////////////////////////////////

		public class Person
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Location { get; set; }

			//'IEnumerable' property with mixed ints and strings
			public IEnumerable<object> Names
			{ 
				get 
				{ 
					yield return Id;
					yield return Name;
					yield return Location;
					yield return "Nickname";
					yield return "Alias";
					yield return 123456;
				} 
			}
		}
	}
}