using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class ExceptionHandlingExamples
	{
		public static void ExceptionHandlingMain()
		{
			Console.WriteLine("\n *********** EXCEPTION HANDLING *********** \n");

			/*
			//Divide by zero exception
			var calc = new Calculator();
			calc.Divide(5, 0);
			*/

			/////////// EXCEPTION MESSAGE ///////////
			///Message: "Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero."
			// - The error message
			// - Exceptions are classes
			///Source: "Mosh"
			// - The application from where the error originated
			///Target Site: "{Int32 Divide(Int32, Int32)}"
			// - The method where the error occured
			///Stack Trace: "at Mosh.ExceptionHandlingExamples.Calculator.Divide(Int32 numerator, Int32 denomenator)
			///				 in C:\Programming\Rando\C#\Mosh\Mosh\ExceptionHandlingExamples.cs:line 27"
			// - Stack trace illustrates the sequence of the error in reverse order

			//Exception handling with try-catch
			try
			{
				//Divide by zero exception
				var calc = new Calculator();
				var result = calc.Divide(5, 0);
				Console.WriteLine($"calc = {result}");
			}
			catch(Exception exceptionString)
			{
				Console.WriteLine($"An error has occured... \n '{exceptionString}'");
			}
		}

		public class Calculator
		{
			public int Divide(int numerator, int denomenator)
			{
				return numerator / denomenator;
			}
		}
	}
}
