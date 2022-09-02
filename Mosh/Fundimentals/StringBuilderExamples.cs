using System;
using System.Text;

namespace PracticeExamples
{
	public class StringBuilderExamples
	{
		public static void StringBuilderMain()
		{
			Console.WriteLine("\n *********** STRING BUILDER EXAMPLES *********** \n");

			var strBuilder = new StringBuilder();

			//Append() -- add '#' symbol to end 3 times
			strBuilder.Append('#', 3);

			//Append() -- add add string to end
			strBuilder.Append("This is an appended string");

			//Append() -- add '#' symbol to end 3 times
			strBuilder.Append('#', 3);

			//AppendLine() -- add a string and line break to end
			strBuilder.AppendLine("  ---line break after this line");

			//Append() -- add add string to end
			strBuilder.Append("This is text after the line break");

			Console.WriteLine(strBuilder);

			//Replace() -- repalce symbol
			strBuilder.Replace('#', '=');
			Console.WriteLine(strBuilder);

			//Remove() -- remove from index 3 to index 26
			strBuilder.Remove(3, 26);
			Console.WriteLine(strBuilder);

			//Insert() -- insert string at index 3
			strBuilder.Insert(3, "This has been inserted");
			Console.WriteLine(strBuilder);
		}
	}
}
