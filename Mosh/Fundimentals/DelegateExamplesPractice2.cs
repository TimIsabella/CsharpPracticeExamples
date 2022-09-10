using System;

namespace PracticeExamples
{
	public class DelegateExamplesPractice2
	{
		public static void DelegateExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** DELEGATE PRACTICE 2 *********** \n");

			int number1 = 9;
			int number2 = 6;
			
			GetSum addition = delegate (double num1, double num2) { return num1 + num2; };
			Console.WriteLine($"{number1} + {number2} = " + addition(number1, number2));

			GetSum subtraction = delegate (double num1, double num2) { return num1 - num2; };
			Console.WriteLine($"{number1} - {number2} = " + subtraction(number1, number2));

			GetSum multiplication = delegate (double num1, double num2) { return num1 * num2; };
			Console.WriteLine($"{number1} * {number2} = " + multiplication(number1, number2));

			GetSum division = delegate (double num1, double num2) { return num1 / num2; };
			Console.WriteLine($"{number1} / {number2} = " + division(number1, number2));
		}

		delegate double GetSum(double num1, double num2);
	}
}
