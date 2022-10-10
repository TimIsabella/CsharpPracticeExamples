using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples.DotNet.Fundamentals
{
	public class IQueryableExamples
	{
		public static void IQueryableExamplesMain()
		{
			Console.WriteLine("\n *********** IQUERYABLE EXAMPLES *********** \n");

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
			
			//Array converted and extended by 'IEnumerable'
			//- 'IEnumerable' extension methods can now be called on the array
			//- Direct conversion since it is compatible
			IEnumerable<Person> peopleArrayEnumerable = peopleArray;

			///'IQueryable' vs 'IEnumerable'
			///- 'IQueryable' is the same as 'IEnumerable' except that on server calls ONLY the requested data will be queried
			///- 'IEnumerable' will make server calls procedurally by queries, which may call the same data repeatedly

			//'List' collection cast as 'IQueryable'
			IQueryable<Person> peopleListQueryable = peopleList.AsQueryable(); //Converted with '.AsQueryable()'

			//'IEnumerable' collection cast as 'IQueryable'
			IQueryable<Person> peopleEnumerableQueryable = (IQueryable<Person>)peopleArrayEnumerable; //'Explicit conversion' using parenthesis

			/// //////////////////////////////////////////////////////////////////

			//Returns an 'IQueryable'
			//- Whole object is returned
			var queryableQuery1 = peopleListQueryable.Where(person => person.Id == 1);

			///Below doesn't work because it is an 'IQueryable' object
			//Console.WriteLine($" Person ID {queryableQuery1.Id} = {queryableQuery1.Name} is in {queryableQuery1.Location}");

			//'foreach' is part of 'IQueryable'
			foreach(Person person in queryableQuery1)
			{ Console.WriteLine($" Person ID {person.Id} = '{person.Name}' who lives in '{person.Location}'"); }

			//Returns an 'IQueryable'
			//- Object string 'Name' is returned
			var queryableQuery2 = from people
								  in peopleEnumerableQueryable
								  where people.Id == 2
								  select people.Name;

			///Below doesn't work because it is an 'IQueryable' string
			//Console.WriteLine($" Person ID 2 Name = '{queryableQuery2.Name}'");

			//'foreach' is part of 'IQueryable'
			foreach(string person in queryableQuery2)
			{ Console.WriteLine($" Person ID 2 Name = '{person}'"); }
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