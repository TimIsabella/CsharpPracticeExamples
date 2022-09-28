using System;

namespace PracticeExamples
{
	public class DelegateExamplesPractice2
	{
		public static void DelegateExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** DELEGATE EXAMPLES PRACTICE 2 *********** \n");

			int number1 = 9;
			int number2 = 6;
			
			GetSum addition = delegate (double num1, double num2) { return num1 + num2; };
			GetSum subtraction = delegate (double num1, double num2) { return num1 - num2; };
			GetSum multiplication = delegate (double num1, double num2) { return num1 * num2; };
			GetSum division = delegate (double num1, double num2) { return num1 / num2; };

			Console.WriteLine($"{number1} + {number2} = " + addition(number1, number2));
			Console.WriteLine($"{number1} - {number2} = " + subtraction(number1, number2));
			Console.WriteLine($"{number1} * {number2} = " + multiplication(number1, number2));
			Console.WriteLine($"{number1} / {number2} = " + division(number1, number2));

			//Directly by delegate class name
			StringMethodsDelegate StringMethodsDelegateContainer;
			StringMethodsDelegateContainer = StringMethod1;
			StringMethodsDelegateContainer += StringMethod2;
			StringMethodsDelegateContainer += StringMethod3;

			StringMethodsDelegateContainer("'String Input'");
		}

		/////////// Delegates ///////////

		public delegate double GetSum(double num1, double num2);
		public delegate void StringMethodsDelegate(string stringInput);

		/////////// Methods for delegate ///////////

		public static void StringMethod1(string stringInput)
		{ Console.WriteLine($"'StringMethod1' delegate: String input is {stringInput}"); }

		public static void StringMethod2(string stringInput)
		{ Console.WriteLine($"'StringMethod2' delegate: String input is {stringInput}"); }

		public static void StringMethod3(string stringInput)
		{ Console.WriteLine($"'StringMethod3' delegate: String input is {stringInput}"); }
	}
}
