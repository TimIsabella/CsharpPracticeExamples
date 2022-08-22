using System;

namespace Mosh
{
	public class DelegateExamplesPractice
	{
		public static void DelegateExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** DELEGATE PRACTICE *********** \n");

			///Directly by class
			DelegateClass.Delegate DelegateContainer;

			DelegateContainer = DelegateClass.MethodForDelegate1;
			DelegateContainer += DelegateClass.MethodForDelegate2;
			DelegateContainer += DelegateClass.MethodForDelegate3;

			DelegateContainer(111); //Call methods in delegate container with argument '111'

			///By constructor
			var delegateClass = new DelegateClass();
			delegateClass.DelegateContainer(222); //Call methods in delegate container with argument '222'

			///By method ('null' in place of 'Delegate')
			delegateClass.DelegateMethod(null); //Call method importing with container and hard-coded '333'
		}

		/////////// Delegate -- a variable which holds methods ///////////

		public class DelegateClass
		{
			// - Declared with 'delegate'
			// - Akin to declaring a class
			// - Below is the 'signature' or 'definition' of a method which it will take (return type of 'void' and takes one int)
			public delegate void Delegate(int num);

			//'DelegateContainer' field
			public Delegate DelegateContainer; //'DelegateContainer' instantiated as a delegate of 'DoSomethingDelegate(int num)'

			//Delegate by constructor
			public DelegateClass()
			{
				DelegateContainer += MethodForDelegate1;
				DelegateContainer += MethodForDelegate2;
				DelegateContainer += MethodForDelegate3;
			}

			//Delegate by method
			public void DelegateMethod(Delegate delegateContainer)
			{
				delegateContainer += MethodForDelegate1;
				delegateContainer += MethodForDelegate2;
				delegateContainer += MethodForDelegate3;

				delegateContainer(333);
			}

			public static void MethodForDelegate1(int num1)
			{ Console.WriteLine($"Delegate: 'MethodForDelegate1' called with value {num1}"); }
			public static void MethodForDelegate2(int num1)
			{ Console.WriteLine($"Delegate: 'MethodForDelegate2' called with value {num1}"); }
			public static void MethodForDelegate3(int num1)
			{ Console.WriteLine($"Delegate: 'MethodForDelegate3' called with value {num1}"); }
		}
	}
}
