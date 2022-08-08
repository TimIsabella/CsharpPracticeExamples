using System;

namespace Mosh
{
	public class Person
	{
		public string Name;
		

		public void Introduce(string firstName = "Not", string lastName = "Sure")
		{
			//Console.WriteLine("My name is " + FirstName + " " + LastName);
			Console.WriteLine("My name is {0} {1}", firstName, lastName);
		}

		public static Person Parse(string str)
		{
		    var person = new Person();
			person.Name = str;

			return person;
		}
	}
}
