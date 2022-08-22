using System;

namespace Mosh
{
	public class DelegateExamplesPractice
	{
		public static void DelegateExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** DELEGATE PRACTICE *********** \n");

			///Directly by class
			Delegate1 DelegateContainer;

			DelegateContainer = Method1ForDelegate1;
			DelegateContainer += Method2ForDelegate1;
			DelegateContainer += Method3ForDelegate1;

			DelegateContainer(111); //Call methods in delegate container with argument '111'

			///By constructor
			var delegateTwo = new DelegateTwo();
			delegateTwo.DelegateContainer("this is a string", 222); //Call methods in delegate container with argument '222'

			///By method ('null' in place of 'Delegate')
			var delegateThree = new DelegateThree();
			delegateThree.DelegateMethod(null); //Call method importing with container and hard-coded '333'
		}

		/////////// Delegate -- a variable which holds methods ///////////

		// - Declared with 'delegate'
		// - Akin to declaring a class
		// - Below is the 'signature' or 'definition' of a method which it will take (return type of 'void' and takes one int)
		public delegate void Delegate1(int num);
		public delegate void Delegate2(string str, int num);
		public delegate void Delegate3(float flo, string str, int num);


		public class DelegateOne
		{
			//'DelegateContainer' field
			public Delegate1 DelegateContainer; //'DelegateContainer' instantiated as a delegate of 'Delegate1(int num)'
		}

		public class DelegateTwo
		{
			//'DelegateContainer' field
			public Delegate2 DelegateContainer; //'DelegateContainer' instantiated as a delegate of 'Delegate2(string str, int num)'

			//Delegate by constructor
			public DelegateTwo()
			{
				DelegateContainer += Method1ForDelegate2;
				DelegateContainer += Method2ForDelegate2;
				DelegateContainer += Method3ForDelegate2;
			}
		}

		public class DelegateThree
		{
			//'DelegateContainer' field
			public Delegate3 DelegateContainer; //'DelegateContainer' instantiated as a delegate of 'Delegate3(float flo, string str, int num)'

			//Delegate by method
			public void DelegateMethod(Delegate3 delegateContainer)
			{
				delegateContainer += Method1ForDelegate3;
				delegateContainer += Method2ForDelegate3;
				delegateContainer += Method3ForDelegate3;

				delegateContainer(1.618f, "this is a string", 333);
			}
		}

		//////////////////////////////////////////////////////////////////

		/////////// Methods for Delegate1 ///////////
		public static void Method1ForDelegate1(int num1)
		{ Console.WriteLine($"Delegate: 'Method1ForDelegate1' called with value {num1}"); }
		public static void Method2ForDelegate1(int num1)
		{ Console.WriteLine($"Delegate: 'Method2ForDelegate1' called with value {num1}"); }
		public static void Method3ForDelegate1(int num1)
		{ Console.WriteLine($"Delegate: 'Method3ForDelegate1' called with value {num1}"); }

		/////////// Methods for Delegate2 ///////////
		public static void Method1ForDelegate2(string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method1ForDelegate2' called with num: {num1}, string: {str1}"); }
		public static void Method2ForDelegate2(string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method2ForDelegate2' called withnum: {num1}, string: {str1}"); }
		public static void Method3ForDelegate2(string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method3ForDelegate2' called with num: {num1}, string: {str1}"); }

		/////////// Methods for Delegate3 ///////////
		public static void Method1ForDelegate3(float flo1, string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method1ForDelegate3' called with num: {num1}, string: {str1}, float: {flo1}"); }
		public static void Method2ForDelegate3(float flo1, string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method2ForDelegate3' called with num: {num1}, string: {str1}, float: {flo1}"); }
		public static void Method3ForDelegate3(float flo1, string str1, int num1)
		{ Console.WriteLine($"Delegate: 'Method3ForDelegate3' called with num: {num1}, string: {str1}, float: {flo1}"); }
	}
}
