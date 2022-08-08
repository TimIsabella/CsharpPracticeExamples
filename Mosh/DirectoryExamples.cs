using System;
using System.IO;

namespace Mosh
{
	public class DirectoryExamples
	{
		public static void DirectoryExamplesMain()
		{
			Console.WriteLine("\n *********** Directory *********** \n");

			if(Directory.Exists("d:\\testDirectory"))
			{
				Directory.Delete("d:\\testDirectory");
				Console.WriteLine("Directory deleted!");
			}

			Directory.CreateDirectory(@"d:\testDirectory");

			//GetDirectory()

			//Exists()

			//GetFiles()

			//GetDirectories
		}
	}
}
