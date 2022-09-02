using System;
using System.IO;

namespace PracticeExamples
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

			var dirInfo = new DirectoryInfo(@"d:\");

			Console.WriteLine(dirInfo.GetDirectories());
			Console.WriteLine(dirInfo.GetFiles());
		}
	}
}
