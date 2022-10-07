using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class BaseExamples
	{
		public static void BaseExamplesMain()
		{
			Console.WriteLine("\n *********** BASE EXAMPLES *********** \n");

			var employee = new Employee(123, "abc", 1.618);
			employee.GetInfo();
			Console.WriteLine("Derived Employee.Numbers: ", employee.Numbers);
			Console.WriteLine("Derived Employee.Strings: ", employee.Strings);
		}


		/// Base class
		public class Person
		{
			public int Numbers;
			public string Strings;
			
			public Person(int numbers, string strings)
			{
				Numbers = numbers;
				Strings = strings;
			}
			
			public virtual void GetInfo()
			{ Console.WriteLine("Base Person class: GetInfo() called"); }
		}

		/// Derived class
		public class Employee : Person
		{
			public double Doubles;

			///'base' specifies that properties for this constructor are inherited from the base class (Person)
			public Employee(int numbers, string strings, double doubles) : base(numbers, strings)
			{
				//Numbers = numbers; -- Inherited by 'base'
				//Strings = strings; -- Inherited by 'base'

				Doubles = doubles;
			}

			public override void GetInfo()                          //Overriding the base class method
			{
				base.GetInfo();                                     ///'base' representing the base class and calling that method directly
				Console.WriteLine("Derived Employee: GetInfo() called");
			}
		}
	}
}
