using System;
using System.Collections.Generic;
using static PracticeExamples.DelegateExamplesPractice3;

namespace PracticeExamples
{
	public class DelegateExamplesPractice4
	{
		public static void DelegateExamplesPractice4Main()
		{
			Console.WriteLine("\n *********** DELEGATE EXAMPLES PRACTICE 4 *********** \n");
			/// A delegate is a type which declares a signature to be associated with a method, and is one of the base types in .Net
			///- Delegates are used to pass methods as parameters or used to define event handlers
			///- Delegates can be either single or multi casted



			//Method wrapped in a delegate
			DelegateSignature delegateCallback = DelegateMethod;

			//Method is called which includes the above delegate wrapped method passed in as a callback
			MethodWithCallback(123, 456, delegateCallback);

			/// /////////// Action ///////////
			actionDelegate1 = () => { Console.WriteLine("actionDelegate1"); };
			actionDelegate2 = (123, 1.618) => { Console.WriteLine("actionDelegate2"); };
		}

		/// /////////// Delegates ///////////
																	///Delegate signature
		public delegate void DelegateSignature(string message);		//One string parameter, returns void

		/// /////////// Built-in delegates ///////////

		public Action actionDelegate1;				//No parameters, returns void
		public Action<int, double> actionDelegate2; //Two parameters, returns void
		public Action<SomeClass> actionDelegate3;   //One generic parameter of 'SomeClass', returns void

		///////////

		public static void DelegateMethod(string message)
		{ Console.WriteLine(message); }

		public static void MethodWithCallback(int intParam1, int intParam2, DelegateSignature callbackDelegate)
		{
			//Callback delegate method invoked
			callbackDelegate($"delegateCallback: Delegate Wrapped Method Callback -- Param1: {intParam1}, Param2: {intParam2}");
		}

		public class SomeClass
		{}
	}
}
