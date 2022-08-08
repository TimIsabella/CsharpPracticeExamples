using System;

namespace Mosh
{
	public class Program
	{
		static void Main()
		{
			Person john = new Person();
			john.Introduce("John", "Smith");

			//Without static below
			//var newPerson = new Person();
			//newPerson.Parse("Rupert");
			//Console.WriteLine("The other person is " + newPerson);

			//With static below
			var newPerson = Person.Parse("Rupert");
			Console.WriteLine("The other person is " + newPerson.Name);

			var customer = new ConstructorExample("Rex");











			//ArraysExamples.ArraysMain();
			//ListExamples.ListsMain();
			
			//DatesAndTimesExamples.DatesAndTimesMain();
			//TimeSpanExamples.TimeSpanMain();

			//int hourAdd = 10;
			//Console.WriteLine("TimeSpanHour method: " + TimeSpanExamples.TimeSpanHour(hourAdd));
			//Console.WriteLine("DatesAndTimesHourAdd: " + DatesAndTimesExamples.DatesAndTimesHourAdd(TimeSpanExamples.TimeSpanHour(hourAdd)));

			//StringExamples.StringExamplesMain();
			//StringBuilderExamples.StringBuilderMain();
			//FileIOexamples.FileIOexamplesMain();
			//DirectoryExamples.DirectoryExamplesMain();
			//PathExamples.PathExamplesMain();
			//ForLoopExample.ForLoopExampleMain();
		}
	}
}
