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

			int newInt = 123;
			double newDouble = 1.618;

			/// /////////// Action Delegate ///////////

			Action action1 = () => { Console.WriteLine("action1"); };

			Action<int, double> action2 = (newInt, newDouble) => { Console.WriteLine("action2."); };

			var someClass = new SomeClass();
			Action<SomeClass> action3 = (someClass) => { Console.WriteLine("action2."); };

			/// /////////// Func Delegate ///////////

			Func<bool> func1 = () => false;
			Func<int, double> func2 = (newInt) => { return 1.23 + newInt; };
		}

		/// /////////// Delegates  
																	///Delegate signature
		public delegate void DelegateSignature(string message);		//One string parameter, returns void

		/// /////////// Built-in delegates: Action ///////////
		//- A delegate type that represents a method
		//- Takes a generic as parameters and returns void

		public Action action1;				//No parameters, returns void
		public Action<int, double> action2; //Two parameters, returns void
		public Action<SomeClass> action3;   //One generic parameter of 'SomeClass', returns void

		/// /////////// Built-in delegates: Func ///////////
		//- A delegate type that represents anonymus functions (lambda) that can be called
		//- Can be used to create anonymus methods or to encapsulate method calls
		//- Takes generic parameters up to 16, and last parameter is the result  or return type

		public Func<bool> func1;  //Returns bool
		public Func<int, double> func2;  //Takes int and returns double

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
