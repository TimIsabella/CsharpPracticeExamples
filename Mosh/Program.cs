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

			var customer1 = new ConstructorExample();
			Console.WriteLine(customer1.Id);
			Console.WriteLine(customer1.FieldName);

			var customer2 = new ConstructorExample(123);
			Console.WriteLine(customer2.Id);
			Console.WriteLine(customer2.FieldName);

			var customer3 = new ConstructorExample(123, "Rex");
			Console.WriteLine(customer3.Id);
			Console.WriteLine(customer3.FieldName);

			var order = new Order();
			customer1.Orders.Add(order);









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
