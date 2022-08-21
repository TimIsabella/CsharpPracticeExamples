using System;

namespace Mosh
{
	public class DelegateExamplesPractice
	{
		public static void DelegateExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** DELEGATE PRACTICE *********** \n");

			var delegateClass = new DelegateClass();
			
			if(delegateClass != null) delegateClass.DelegateContainer(123);
		}

		/////////// Delegate -- a variable which holds methods ///////////

		public class DelegateClass
		{
			// - Declared with 'delegate'
			// - Akin to declaring a class
			// - Below is the 'signature' or 'definition' of a method which it will take (return type of 'void' and takes one int)
			public delegate void DoSomethingDelegate(int num);

			public DoSomethingDelegate DelegateContainer; //'DelegateContainer' instantiated as a delegate of 'DoSomethingDelegate(int num)'

			public DelegateClass()
			{
				DelegateContainer += MethodForDelegate1;
				DelegateContainer += MethodForDelegate2;
			}

			private void MethodForDelegate1(int num1)
			{
				Console.WriteLine($"Delegate: 'MethodForDelegate1' called with value {num1}");
			}

			private void MethodForDelegate2(int num1)
			{
				Console.WriteLine($"Delegate: 'MethodForDelegate2' called with value {num1}");
			}
		}
	}
}
