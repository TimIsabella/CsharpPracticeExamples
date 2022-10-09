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

			//////////////////////////////////////////////////////////////////

			//'List' collection down casted to 'IEnumerable'
			//- 'List' is a higher form of 'IEnumerable'
			//- Converted using '.AsEnumerable()'
			IEnumerable<Person> peopleListEnumerable = peopleList.AsEnumerable();

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

			//////////////////////////////////////////////////////////////////

			//Returns an 'IQueryable'
			//- Whole object is returned
			var output1 = peopleListQueryable.Where(person => person.Id == 1);

			///Below doesn't work because it is an 'IQueryable' object
			//Console.WriteLine($" Person ID {output1.Id} = {output1.Name} is in {output1.Location}");

			//'foreach' is part of 'IQueryable'
			foreach(Person person in output1)
			{ Console.WriteLine($" Person ID {person.Id} = '{person.Name}' who lives in '{person.Location}'"); }

			//Returns an 'IQueryable'
			//- Object string 'Name' is returned
			var output2 = from people
						  in peopleEnumerableQueryable
						  where people.Id == 2
						  select people.Name;

			///Below doesn't work because it is an 'IQueryable' string
			//Console.WriteLine($" Person ID 2 Name = '{output2.Name}'");

			//'foreach' is part of 'IQueryable'
			foreach(string person in output2)
			{ Console.WriteLine($" Person ID 2 Name = '{person}'"); }
		}

		public class Person
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Location { get; set; }
		}
	}
}