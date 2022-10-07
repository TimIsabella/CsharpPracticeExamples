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
		}


		//////////////////////////////////////////////////////////////////
		public class BasePerson
		{
			//'Protected' allows fields to be inherited
			protected int Numbers;
			protected string Strings;
			
			public BasePerson(int numbers, string strings)
			{
				Numbers = numbers;
				Strings = strings;
			}
			
			public virtual void GetInfo()
			{ Console.WriteLine("Person class: GetInfo() called"); }
		}

		public class Employee : BasePerson
		{
			double Doubles;

			///'base' specifies that properties for this constructor are for the base class (Person)
			public Employee(int numbers, string strings, double doubles) : base(numbers, strings)
			{ 
				Numbers = numbers;
				Strings = strings;
				Doubles = doubles;
			}

			public override void GetInfo()                          //Overriding the derived class method
			{
				base.GetInfo();                                     ///'base' representing the derived class and calling that method directly
				Console.WriteLine("Employee: GetInfo() called");
			}
		}
	}
}
