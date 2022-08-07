using System;

namespace Mosh
{
	public class Program
	{
		static void Main()
		{
			Person john = new Person();
			john.Introduce("John", "Smith");

			ArraysExamples.ArraysMain();
			ListExamples.ListsMain();
			DatesAndTimesExample.DatesAndTimesMain();
		}
	}
}
