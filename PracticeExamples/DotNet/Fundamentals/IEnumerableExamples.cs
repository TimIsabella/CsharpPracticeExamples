using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PracticeExamples.DotNet.Fundamentals
{
	public class IEnumerableExamples
	{
		public static void IEnumerableExamplesMain()
		{
			Console.WriteLine("\n *********** IENUMERABLE EXAMPLES *********** \n");
			/// IEnumerable<T> is the base interface for ALL non-generic collections in .NET -- it is the basic support for iteration or traversing a collection
			//- Provides a simple way to enumerate the contents of a collection
			//- All .NET collection types (arrays, List<T>, etc.) implement IEnumerable<T>

			///LINQ
			//- IEnumerable<T> is the CENTRAL interface for LINQ operations
			//- Doses not have LINQ operators built in so must implement those operators with a 'Func<T>' argument -- known as 'LINQ to Objects'
			//- Since IEnumerable does not have LINQ built in, its process of LINQ operators is a 'deferres execution'
			//- The deferred execution is a major performance advantage by querying objects in memory AFTER the full query has been established
			//- The alternative would be to write multiple nested for loops and run the logic therein

			var para1 = new Params(1, 2, 3);                // All these are cast as 'IEnumerable<int>'
			Params para2 = new Params(4, 5, 6);				//
			IEnumerable<int> para3 = new Params(4, 5, 6);	//

			foreach(var p in para3)							//'foreach' only runs on collections exposed by 'IEnumerable'
			{ Console.WriteLine(p); }

			///////////

			var person = new Person("First name", "Middle name", "Last name");

			foreach(var name in person.Names)
			{ Console.WriteLine(name); }
		}

		///////////////////////////////////////////////////////////////////////////////////////////////////

		//'Params' implements 'IEnumerable' interface to supports a simple iteration over a collection (foreach functionality)
		public class Params : IEnumerable<int>
		{
			private int _a, _b, _c;

			public Params(int a, int b, int c)
			{
				_a = a;
				_b = b;
				_c = c;
			}

			//When 'GetEnumerator()' is called, each 'yield' return is called one by one with the 'helper method' below
			public IEnumerator<int> GetEnumerator()
			{
				yield return _a;
				yield return _b;
				yield return _c;
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
			private string _firstName, _middleName, _lastName;

			public Person(string firstName, string middleName, string lastName)
			{
				_firstName = firstName;
				_middleName = middleName;
				_lastName = lastName;
			}

			public IEnumerable<string> Names
			{ 
				get 
				{ 
					yield return _firstName;
					yield return _middleName;
					yield return _lastName;
					yield return "Nickname";
					yield return "Alias";
					yield return "Maiden name";
				} 
			}
		}
	}
}