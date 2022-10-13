using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class DependencyInversionPractice1
	{
		public static void DependencyInversionPractice1Main()
		{
			Console.WriteLine("\n *********** DEPENDENCY INVERSION PRINCIPAL PRACTICE 1 *********** \n");
			///- High level parts of the system should not depend on low level parts of the system directly
			///- Instead they should depend on abstraction

			///Interface based dependency inversion
			ILogger fileLogger = new FileLogger(); //Class inheriting 'ILogger' interface is instantiated as the interface
			fileLogger.Log("Hello world!");        //Interface is called which is connected to the class

			///Setter based dependency inversion (dependency injection)
			var consoleLogger = new DependencyInjection(new ConsoleLogger());
			consoleLogger.CallLog("Hello world!");
		}

		//////////////////////////////////////////////////////////////////

		public interface ILogger
		{ void Log(string message); }

		///////////

		public class FileLogger : ILogger
		{ 
			public void Log(string message)
			{ Console.WriteLine($"FileLogger: '{message}'"); }
		}

		public class ConsoleLogger : ILogger
		{
			public void Log(string message)
			{ Console.WriteLine($"FileLogger: '{message}'"); }
		}

		///////////

		public class DependencyInjection
		{
			private ILogger _logger { get; set; }

			public DependencyInjection(ILogger logger)
			{ _logger = logger; }

			public void CallLog(string message)
			{ _logger.Log(message); }
		}
	}
}