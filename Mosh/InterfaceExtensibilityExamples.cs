using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class InterfaceExtensibilityExamples
	{
		public static void InterfaceExtensibilityExamplesMain()
		{
			Console.WriteLine("\n *********** INTERFACE EXTENSIBILITIES EXAMPLES *********** \n");

			var databaseMigrator = new DatabaseMigrator(new ConsoleLogger());
			databaseMigrator.Migrate();
		}

		public class DatabaseMigrator
		{
			private readonly ILogger _logger;

			//'Dependancy Injection' - specifying a dependancy for the class
			//'ILogger' interface passed into constructor
			public DatabaseMigrator(ILogger logger)
			{
				_logger = logger;
			}
			
			public void Migrate()
			{
				_logger.LogInfo($"Migration started at {DateTime.Now}");

				//Code here

				_logger.LogInfo($"Migration completed at {DateTime.Now}");
			}
		}

		public interface ILogger
		{
			void LogError(string message);
			void LogInfo(string message);
		}

		public class ConsoleLogger : ILogger
		{
			public void LogError(string msg)
			{ 
				Console.WriteLine(msg);
			}
			public void LogInfo(string msg)
			{ 
				Console.WriteLine(msg);
			}
		}
	}
}
