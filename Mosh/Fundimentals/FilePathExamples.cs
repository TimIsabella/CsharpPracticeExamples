using System;
using System.IO;

namespace PracticeExamples
{
	public class FilePathExamples
	{
		public static void FilePathExamplesMain()
		{
			Console.WriteLine("\n *********** FILE PATH *********** \n");

			var testPath = @"D:\test-original.txt";
			Console.WriteLine("Current path: '{0}'", testPath);

			//Get filename of path
			Console.WriteLine("File name '{0}': ", Path.GetFileName(testPath));

			//Get filename WITHOUT extension
			Console.WriteLine("File name ONLY '{0}': ", Path.GetFileNameWithoutExtension(testPath));

			//Get file extension of path
			Console.WriteLine("File extension '{0}': ", Path.GetExtension(testPath));

			//Get file directory name from path
			Console.WriteLine("File directory '{0}': ", Path.GetDirectoryName(testPath));
		}
	}
}
