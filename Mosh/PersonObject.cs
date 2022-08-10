using System;

namespace Mosh
{
	public class PersonObject
	{
		public string FullName;
		public string NickName;
		

		public void Introduce(string firstName = "Not", string lastName = "Sure")
		{
			//Console.WriteLine("My name is " + FirstName + " " + LastName);
			Console.WriteLine("My name is '{0} {1}'", firstName, lastName);
		}

		public static PersonObject Parse(string str)
		{
		    var person = new PersonObject();
			person.FullName = str;

			return person;
		}
	}
}
