using System;

namespace Mosh
{
	public class Program
	{
		static void Main()
		{
			/*
			PersonObject john = new PersonObject();
			john.Introduce("John", "Smith");

			//Without static below
			//var newPerson = new PersonObject();
			//newPerson.Parse("Rupert");
			//Console.WriteLine("The other person is " + newPerson);

			//With static below
			var newPerson = PersonObject.Parse("Rupert");
			Console.WriteLine("The other person is " + newPerson.FullName);

			var customer1 = new ConstructorExample();
			Console.WriteLine(customer1.Id);
			Console.WriteLine(customer1.FieldName);

			var customer2 = new ConstructorExample(123);
			Console.WriteLine(customer2.Id);
			Console.WriteLine(customer2.FieldName);

			var customer3 = new ConstructorExample(123, "Rex");
			Console.WriteLine(customer3.Id);
			Console.WriteLine(customer3.FieldName);

			var order = new OrderObject();
			customer1.Orders.Add(order);

			//Object initialization
			var personObjectInitilizer = new PersonObject
			{
				FullName = "John",
				NickName = "Jonny"
			};

			Console.WriteLine("Fullname: {0} \n Nickname: {1}", personObjectInitilizer.FullName, personObjectInitilizer.NickName);
			*/

			/*
			ArraysExamples.ArraysMain();
			ListExamples.ListsMain();

			DatesAndTimesExamples.DatesAndTimesMain();
			TimeSpanExamples.TimeSpanMain();

			int hourAdd = 10;
			Console.WriteLine("TimeSpanHour method: " + TimeSpanExamples.TimeSpanHour(hourAdd));
			Console.WriteLine("DatesAndTimesHourAdd: " + DatesAndTimesExamples.DatesAndTimesHourAdd(TimeSpanExamples.TimeSpanHour(hourAdd)));
			*/

			/*
			StringBuilderExamples.StringBuilderMain();
			FileIOexamples.FileIOexamplesMain();
			DirectoryExamples.DirectoryExamplesMain();
			PathExamples.PathExamplesMain();
			ForLoopExample.ForLoopExampleMain();
			StringExamples.StringExamplesMain();
			MethodExamples.MethodExamplesMain();
			AccessModifiersExamples.AccessModifiersExamplesMain();
			PropertiesExamples.PropertiesExerciseMain();
			IndexerExamples.IndexerExamplesMain();
			InheritanceExamples.InheritanceExamplesMain();
			CompositionExamples.CompositionExamplesMain();
			AccessModifiersExamplesAdvanced.AccessModifiersExamplesAdvancedMain();
			ConstructorExampleAdvanced.ConstructorExampleAdvancedMain();
			UpDownCasting.UpDownCastingMain();
			MethodOverridingExamples.MethodOverridingExamplesMain();
			AbstractExamples.AbstractExamplesMain();
			SealedModifiersExample.SealedModifiersExampleMain();
			InterfaceExamples.InterfaceExamplesMain();
			*/

			InterfaceExtensibilityExamples.InterfaceExtensibilityExamplesMain();
			InterfacePolymorphismExamples.InterfacePolymorphismExamplesMain();
			GenericsExamples.GenericsExamplesMain();
			DelegateExamples.DelegateExamplesMain();
			LambdaExamples.LambdaExamplesMain();
		}
	}
}
