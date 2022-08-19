using System;
using System.Collections.Generic;
using System.IO;
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

			/////////// Manual Exception throwing ///////////
			///  throw new Exception("OOPS: I threw an exception!");

			/////////// Exception handling with try-catch /////////// 
			// - Catch of more specific exception type takes priority
			// - Catches must be ordered from most specific to least specific
			// - Only one catch will be fired
			try
			{
				//Divide by zero exception
				var calc = new Calculator();
				var result = calc.Divide(5, 0);
				Console.WriteLine($"calc = {result}");
			}

			//Specific exception handling -- Most specific
			catch(DivideByZeroException divideByZeroEx)
			{ Console.WriteLine($"A divide by zero error has occured... \n '{divideByZeroEx}'"); }

			//Generic exception handling
			catch(ArithmeticException arithmeticEx)
			{ Console.WriteLine($"An arithmetic error has occured... \n '{arithmeticEx}'"); }

			//General exception handling -- Least specific
			catch(Exception exceptionString)
			{ Console.WriteLine($"An error has occured... \n '{exceptionString}'"); }

			/////////// 'Finally' block /////////// 
			// - Called after all catches for additional processing

			Console.WriteLine("\n *** Stream Read *** \n");
			StreamReader streamReader = null;

			try
			{
				Console.WriteLine("Stream Read: Preparing to read stream...");
				streamReader = new StreamReader(@"D:\thisFileDoesntExist.txt");
				var content = streamReader.ReadToEnd();

				Console.WriteLine($"Stream Read: '{content}'");
			}

			catch(Exception exceptionString)
			{ Console.WriteLine($"Stream Read: An error has occured... \n '{exceptionString}'"); }
			
			finally
			{
				Console.WriteLine("Stream Read: Disposing of 'streamReader' following error.");
			    
				//Dispose of the stream read (with null check)
				if(streamReader != null) streamReader.Dispose();
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
