using System;

namespace Mosh
{
	public class Program
	{
		static void Main()
		{
			Person john = new Person();
			//john.FirstName = "John";
			//john.LastName = "Smith";
			john.Introduce("John", "Smith");

			ArraysExamples.ArraysMain();
		}
	}
}
