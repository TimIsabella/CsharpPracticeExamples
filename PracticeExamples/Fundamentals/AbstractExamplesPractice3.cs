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

			var overriddenClasses = new List<BaseClass>();

			overriddenClasses.Add(new OverrideClass1());
			overriddenClasses.Add(new OverrideClass2());
			overriddenClasses.Add(new OverrideClass3());

			overriddenClasses[0].Method3();
			overriddenClasses[1].Method2();
			overriddenClasses[2].Method1();
		}

		/////////// Base abstract class ///////////
		public abstract class BaseClass
		{
			public abstract void Method1();
			public abstract void Method2();
			public abstract void Method3();
		}

		/////////// Override classes ///////////
		class OverrideClass1 : BaseClass
		{
			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}

		class OverrideClass2 : BaseClass
		{
			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}

		class OverrideClass3 : BaseClass
		{
			public override void Method1()
			{ }
			public override void Method2()
			{ }
			public override void Method3()
			{ }
		}
	}
}
