using System;

namespace Mosh
{
	public class Person
	{
		//public string FirstName;
		//public string LastName;

		public void Introduce(string firstName = "Not", string lastName = "Sure")
		{
			//Console.WriteLine("My name is " + FirstName + " " + LastName);
			Console.WriteLine("My name is " + firstName + " " + lastName);
		}
	}
}
