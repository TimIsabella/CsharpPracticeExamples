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
			
			//Delegate 'invoked' and method wrapped in that delegate
			DelegateSignature delegateCallback = DelegateMethod;

			//Method is called which includes the above delegate wrapped method passed in as a callback
			MethodWithCallback(123, 456, delegateCallback);

			/// /////////// Action Delegate ///////////

			Action action1 = () => { Console.WriteLine("action1"); };
			Action<int, double> action2 = (intParam, doubleParam) => { Console.WriteLine($"action2 -- Param1: {intParam}, Param2: {doubleParam}"); };
			Action<SomeClass> action3 = (someClass) => { Console.WriteLine("action3..."); };
			Action<string> action4 = (stringMessage) => { ActionDelegateMethod(stringMessage); };

			//Invoke the action delegate
			action1();
			action2(123, 1.618);
			action3(new SomeClass());

			ActionMethodWithCallback(action4, "Message for Action Delegate Method");

			/// /////////// Func Delegate ///////////

			Func<bool> func1 = () => false;
			Func<int, double> func2 = (newInt) => { return 1.23 + newInt; };  //One int parameter and return type double
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

		/// //////////////////////////////////////////////////////////////////

		/////////// Methods for callback ///////////
		public static void DelegateMethod(string message)
		{ Console.WriteLine(message); }

		public static void ActionDelegateMethod(string message)
		{ Console.WriteLine(message); }

		/////////// Other ///////////
		public static void MethodWithCallback(int intParam1, int intParam2, DelegateSignature callback)
		{
			//Callback delegate method invoked
			callback($"MethodWithCallback: Delegate Wrapped Method Callback -- Param1: {intParam1}, Param2: {intParam2}");
		}

		public static void ActionMethodWithCallback(Action<string> callback, string stringParam)
		{
			Console.Write($"ActionMethodWithCallback: Action Delegate Wrapped Method Callback... ");

			//Callback action delegate method invoked with string
			callback(stringParam);
		}

		public class SomeClass
		{}
	}
}
