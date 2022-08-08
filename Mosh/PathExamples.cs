using System;
using System.IO;

namespace Mosh
{
	public class PathExamples
	{
		public static void PathExamplesMain()
		{
			Console.WriteLine("\n *********** Path *********** \n");

			var testPath = @"D:\test-original.txt";
			Console.WriteLine("Current path: '{0}'", testPath);

			//Get filename of path
			Console.WriteLine("File name '{0}': ", Path.GetFileName(testPath));

			//Get filename WITHOUT extension
			Console.WriteLine("File name ONLY '{0}': ", Path.GetFileNameWithoutExtension(testPath));

			//Get file extension of path
			Console.WriteLine("File extension '{0}': ", Path.GetExtension(testPath));
		}
	}
}
