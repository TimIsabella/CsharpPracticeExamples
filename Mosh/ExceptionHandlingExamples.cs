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
			//Exception Message: 'Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.'
			//- Exceptions are classes
			//Stack Trace: 'at Mosh.ExceptionHandlingExamples.Calculator.Divide(Int32 numerator, Int32 denomenator) in C:\Programming\Rando\C#\Mosh\Mosh\ExceptionHandlingExamples.cs:line 27'
			//- Stack trace illustrates the sequence of the error

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
