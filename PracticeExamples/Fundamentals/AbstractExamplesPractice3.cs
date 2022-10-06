using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples
{
	public class AbstractExamplesPractice3
	{
		public static void AbstractExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** ABSTRACT EXAMPLES PRACTICE 3 *********** \n");
			///the 'abstract' keyword is applied to classes, methods, and properties to create base class of members in which to override
			///- ALL abstract methods and properties of the base abstract class MUST be implimented (similar to interfaces)
			///- Abstract methods contain no implimentation (no curly braces or logic, similar to interfaces)
			///- Abstract classes cannot be instantiated

			var overriddenClasses = new List<BaseClass>();

			overriddenClasses.Add(new OverrideClass1());
			overriddenClasses.Add(new OverrideClass2());
			overriddenClasses.Add(new OverrideClass3());

			overriddenClasses[0].Method3();
			overriddenClasses[1].Method2();
			overriddenClasses[2].Method1();

			//Abstract classes cannot be instantiated
			//var baseClass = new BaseClass();
		}

		/////////// Base abstract class ///////////
		public abstract class BaseClass
		{
			public abstract int SomeProperty { get; set; }
			public int Numbers;	//Fields cannot be abstract

			public BaseClass()	//Constructors cannot be abstract
			{ }

			public abstract void Method1();
			public abstract void Method2();
			public abstract void Method3();
		}

		/////////// Override classes ///////////
		class OverrideClass1 : BaseClass
		{
			public override int SomeProperty { get; set; }

			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}

		class OverrideClass2 : BaseClass
		{
			public override int SomeProperty { get; set; }

			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}

		class OverrideClass3 : BaseClass
		{
			public override int SomeProperty { get; set; }

			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}
	}
}
