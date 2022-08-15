using System;
using System.IO;

namespace Mosh
{
	public class InterfaceExtensibilityExamples
	{
		public static void InterfaceExtensibilityExamplesMain()
		{
			Console.WriteLine("\n *********** INTERFACE EXTENSIBILITIES EXAMPLES *********** \n");

			var databaseMigratorConsole = new DatabaseMigrator(new ConsoleLogger());
			databaseMigratorConsole.Migrate();

			var databaseMigratorFile = new DatabaseMigrator(new FileLogger("D:\\testlog.txt"));
			databaseMigratorFile.Migrate();
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

		public class FileLogger : ILogger
		{
			private readonly string _path;
			public FileLogger(string path)
			{
				_path = path;
			}

			//Below code is DRY
			private void Log(string msgType, string msg)
			{
				//Stream write to file at '_path' and overwrite as 'true'
				//'using' provides exception handling
				using(var streamWriter = new StreamWriter(_path, true))
				{
					streamWriter.WriteLine($"{msgType}: {msg}");    //Write to file
				}
			}

			public void LogError(string msg)
			{ Log("ERROR", msg); }

			public void LogInfo(string msg)
			{ Log("INFO", msg); }

			//Repeated code is not DRY
			/*
			public void LogError(string msg)
			{
				//Stream write to file at '_path' and overwrite as 'true'
				var streamWriter = new StreamWriter(_path, true);
				streamWriter.WriteLine($"Error {msg}");  //Write to file
				streamWriter.Dispose();					 //Release 'WriteLine' resource
			}

			public void LogInfo(string msg)
			{
				//Stream write to file at '_path' and overwrite as 'true'
				//'using' provides exception handling
				using(var streamWriter = new StreamWriter(_path, true))
				{
					streamWriter.WriteLine(msg);    //Write to file
				}
			}
			*/
		}

		//////////////////////////////////////////////////////////////////

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
