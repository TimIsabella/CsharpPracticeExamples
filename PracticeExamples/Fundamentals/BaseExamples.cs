using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class BaseExamples
	{
		public static void BaseExamplesMain()
		{
			Console.WriteLine("\n *********** BASE EXAMPLES *********** \n");

			var derivedObject = new DerivedClass(123, "abc", 1.618);
			derivedObject.GetInfo();
			Console.WriteLine("derivedObject.Numbers: ", derivedObject.Numbers);
			Console.WriteLine("derivedObject.Strings: ", derivedObject.Strings);
		}


		//////////////////////////////////////////////////////////////////
		public class BaseClass
		{
			public int Numbers;
			public string Strings;
			
			public BaseClass(int numbers, string strings)
			{
				Numbers = numbers;
				Strings = strings;
			}
			
			public virtual void GetInfo()
			{ Console.WriteLine("Person class: GetInfo() called"); }
		}

		public class DerivedClass : BaseClass
		{
			public double Doubles;

			///'base' specifies that properties for this constructor are inherited from the base class (BaseClass)
			public DerivedClass(int numbers, string strings, double doubles) : base(numbers, strings)
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
