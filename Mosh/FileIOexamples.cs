using System;
using System.IO;

namespace Mosh
{
	public class FileIOexamples
	{
		public static void FileIOexamplesMain()
		{
			Console.WriteLine("\n *********** FILE I/O *********** \n");

			string fileToDelete = @"d:\test-copy2.txt";

			//Check if file exists, and delete if true
			if(File.Exists(fileToDelete))
			{
				File.Delete(fileToDelete);
				Console.WriteLine("File deleted!");
			}
			
			//Copy() - Source file, destination file, overwrite flag
			File.Copy("d:\\test-original.txt", "d:\\test-copy.txt", true);

			//Move() - Source file, destination file
			File.Move(@"d:\test-copy.txt", @"d:\test-copy2.txt");

			//Output file path and contents
			Console.WriteLine("File contents: '{0}'", File.ReadAllText(@"d:\test-copy2.txt"));
		}
	}
}
