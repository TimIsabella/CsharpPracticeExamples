using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class DelegateExamplesPractice3
	{
		public static void DelegateExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** DELEGATE EXAMPLES PRACTICE 3 *********** \n");
			/// A delegate is a class which encapsulates a method signature, and is one of the base types in .Net
			///- Delegates are used to pass methods as parameters or used to define event handlers
			///- Delegates can be either single or multi casted

			/// /////////// Anonymus Singlecast Delegate Invocation ///////////
			int number1 = 3, number2 = 6;

			//'GetSumDelegate' instantiated as 'sumDelegate' and provided a single anonymus delegate
			GetSumDelegate sumDelegate = delegate (double num1, double num2) { return num1 + num2; };

			//Invoke 'sumDelegate' delegate with arguments and capture result
			double delegateResult = sumDelegate(number1, number2);		

			//Output results
			Console.WriteLine($"sumDelegate: Singlecast Delegate -- {number1} + {number2} = " + delegateResult);

			/// /////////// Anonymus Multicast Delegate Invocation ///////////
			//- Multi-casting a delegate adds multiple methods to its invocation list
			//- This delegate is thought of as 'pointing' to multiple methods

			string delegateName = "consoleDelegate: Anonymus Multicast Delegate List --";
			string delegateString = "Message from delegate!";

			//'ConsoleDelegate' instantiated as 'consoleDelegate' and provided multiple anonymus delegates
			ConsoleDelegate consoleDelegate = delegate (string string1, string string2) { Console.WriteLine($"{string1} {string2}"); };
							consoleDelegate += delegate (string string1, string string2) { Console.WriteLine($"{string1} {string2}"); };
							consoleDelegate += delegate (string string1, string string2) { Console.WriteLine($"{string1} {string2}"); };

			//Invoke 'consoleDelegate' with arguments
			//- Invokes each delegate in the invokation list
			//- Each is invoked in order by which is was added
			consoleDelegate(delegateName, delegateString);

			/// /////////// Singlecast Delegate Invocation ///////////

			//Method wrapped in a delegate
			//- A delegate can be passed into a method as a parameter
			//- A method passed into a method is a 'callback'
			DelegateForMethod delegateHandler = DelegateMethod;

			//Method is called which includes the above delegate wrapped method passed in as a callback
			//- The delegate wrapped callback will be invoked within the method below
			MethodWithCallback(123, 456, delegateHandler);

			/// /////////// Multicast Delegate Invocation ///////////

			AnotherDelegate anotherDelegate;
							anotherDelegate = AnotherMethod2;	//Add
							anotherDelegate -= AnotherMethod2;  //Remove
							anotherDelegate += AnotherMethod1;  //Add
							anotherDelegate += AnotherMethod2;  //Add
							anotherDelegate += delegate (int num1, string num2) { Console.WriteLine("anotherDelegate: Multicast Delegate List -- Anonymus Delegate."); }; //Add anonymus delegate of matching signature

			//Invoke delegate list with arguments
			anotherDelegate(123, "Another string");
		}

		/// /////////// Delegates ///////////
																							///Delegate signature
		public delegate double GetSumDelegate(double numInput1, double numInput2);			//Two double parameters, returns double
		public delegate void ConsoleDelegate(string stringParam1, string stringParam2);		//Two string parameters, returns void
		public delegate void DelegateForMethod(string message);								//One string parameter, returns void
		public delegate void AnotherDelegate(int intParam, string stringParam);				//One int and one string parameter, returns void

		///////////

		public static void DelegateMethod(string message)
		{ Console.WriteLine(message); }

		public static void MethodWithCallback(int intParam1, int intParam2, DelegateForMethod callbackDelegate)
		{ 
			//Callback delegate method invoked
			callbackDelegate($"delegateHandler: Delegate Wrapped Method Callback -- Param1: {intParam1}, Param2: {intParam2}"); 
		}

		///////////

		public static void AnotherMethod1(int intParam, string stringParam)
		{ Console.WriteLine($"anotherDelegate: Multicast Delegate List -- AnotherMethod1 -- Int input: '{intParam}' , String input: '{stringParam}'"); }

		public static void AnotherMethod2(int intParam, string stringParam)
		{ Console.WriteLine($"anotherDelegate: Multicast Delegate List -- AnotherMethod2 -- Int input: '{intParam}' , String input: '{stringParam}'"); }
	}
}
