using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeExamples.DotNet.Fundamentals
{
    public class IenumerableExamples
    {
        public static void IenumerableExamplesMain()
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
            
            var para = new Params(1, 2, 3);

            foreach(var p in para)
            { Console.WriteLine(p); }

            var person = new Person("First name", "Middle name", "Last name");

            foreach(var name in person.Names)
            { Console.WriteLine(name); }
        }

        public class Params : IEnumerable<int>
        {
            private int _a, _b, _c;

            public Params(int a, int b, int c)
            {
                _a = a;
                _b = b;
                _c = c;
            }

			public IEnumerator<int> GetEnumerator()
			{
				yield return _a;
				yield return _b;
				yield return _c;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{ return GetEnumerator(); }
		}

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
				} 
            }
        }
    }
}
