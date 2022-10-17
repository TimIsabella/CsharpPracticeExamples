using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class DelegateExamplesPractice3
	{
		public static void DelegateExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** DELEGATE EXAMPLES PRACTICE 3 *********** \n");

			int number1 = 9;
			int number2 = 6;

			//'GetSumDelegate' instantiated as 'addition' 
			GetSumDelegate additionDelegate = delegate (double num1, double num2)
			{ return num1 + num2; };

			//Calls 'addition' delegate called with arguments
			Console.WriteLine($"{number1} + {number2} = " + additionDelegate(number1, number2));

			///

			DelegateForMethod delegateHandler = DelegateMethod;
			delegateHandler("delegateHandler: This is a string");

			//Call method and pass in delegate
			//- Delegate to be used within method
			MethodWithCallback(123, 456, delegateHandler);

			///

			//Directly by delegate class name
			StringMethodsDelegate stringMethodsDelegateContainer;
			stringMethodsDelegateContainer = StringMethod1;
			stringMethodsDelegateContainer += StringMethod2;
			stringMethodsDelegateContainer += StringMethod3;

			stringMethodsDelegateContainer("'DELEGATE PARAMETER'");

			///

			AnotherDelegate anotherDelegateContainer;
			anotherDelegateContainer = AnotherMethod1;
			anotherDelegateContainer += AnotherMethod1;
			anotherDelegateContainer += AnotherMethod2;

			anotherDelegateContainer(123, "Another string");
		}

		///////////

		public delegate double GetSumDelegate(double numInput1, double numInput2);  //Two double parameters, returns double

		/////////// 

		public delegate void DelegateForMethod(string message);

		public static void DelegateMethod(string message)
		{ Console.WriteLine(message); }

		public static void MethodWithCallback(int intParam1, int intParam2, DelegateForMethod callbackDelegate)
		{ callbackDelegate($"callbackDelegate -- Param1: {intParam1}, Param2: {intParam2}"); }

		///////////

		public delegate void StringMethodsDelegate(string stringInput);             //One string parameter, returns void

		public static void StringMethod1(string stringParam)
		{ Console.WriteLine($"'StringMethod1' delegate: String input is {stringParam}"); }

		public static void StringMethod2(string stringParam)
		{ Console.WriteLine($"'StringMethod2' delegate: String input is {stringParam}"); }

		public static void StringMethod3(string stringParam)
		{ Console.WriteLine($"'StringMethod3' delegate: String input is {stringParam}"); }

		///////////

		public delegate void AnotherDelegate(int intParam, string stringParam);     //One int one string parameter, returns void

		public static void AnotherMethod1(int intParam, string stringParam)
		{ Console.WriteLine($"'AnotherMethod1' delegate -- Int input: '{intParam}' , String input: '{stringParam}'"); }

		public static void AnotherMethod2(int intParam, string stringParam)
		{ Console.WriteLine($"'AnotherMethod2' delegate -- Int input: '{intParam}' , String input: '{stringParam}'"); }
	}
}
