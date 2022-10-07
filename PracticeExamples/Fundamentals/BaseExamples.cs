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
			Console.WriteLine("Employee.Numbers: ", employee.Numbers);
			Console.WriteLine("Eployee.Strings: ", employee.Strings);
		}


		//////////////////////////////////////////////////////////////////
		public class BasePerson
		{
			//'Protected' allows fields to be inherited
			public int Numbers;
			public string Strings;
			
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
			public double Doubles;

			///'base' specifies that properties for this constructor are inherited from the base class (Person)
			public Employee(int numbers, string strings, double doubles) : base(numbers, strings)
			{
				//Numbers = numbers; -- Inherited by 'base'
				//Strings = strings; -- Inherited by 'base'

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
