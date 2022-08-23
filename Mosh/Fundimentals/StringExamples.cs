using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class StringExamples
	{
		public static void StringExamplesMain()
		{
			Console.WriteLine("\n *********** STRING EXAMPLES *********** \n");

			string stringForInt = "123";

			//Parse to int
			int intFromString1 = int.Parse(stringForInt);
			Console.WriteLine("int.Parse(stringForInt): " + intFromString1);

			//Convert to int 32 -- returns 0 if string is empty
			Console.WriteLine("Convert.ToInt32(stringForInt): " + Convert.ToInt32(stringForInt));

			//ToString() -- converts to formatted type
			Console.WriteLine("intFromString2.ToString('C'): " + intFromString1.ToString("C"));

			string randomWords = "  This is a RANDOM string of words!   ";

			//ToLower()
			Console.WriteLine("To lower: " + randomWords.ToLower());

			//ToUpper()
			Console.WriteLine("To upper: " + randomWords.ToUpper());

			//Trim()
			Console.WriteLine("Trimmed white space: '{0}' ", randomWords.Trim());

			//Chained methods
			Console.WriteLine("Chained: '{0}'", randomWords.Trim().ToUpper().Replace("RANDOM", "CHAINED"));

			//Substring()
			string twoWords = "First Second";
			int spaceIndex = twoWords.IndexOf(' ');
			Console.WriteLine("{0} {1}", twoWords.Substring(0, spaceIndex), twoWords.Substring(spaceIndex + 1));

			//Split()
			string[] stringArray = randomWords.Trim().Split(' ');
			Console.WriteLine("{0} {1} {2}", stringArray[0], stringArray[1], stringArray[3]);

			//IndexOf('a')

			//LastIndexOf("Hello")

			//Substring()

			//Replace('a', "world")

			//String.IsNullOrEmpty(string)

			//String.IsNullOrWhiteSpace(string)

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("This text is colored RED");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("This text is colored Blue");

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("This text is colored GREEN");

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("This text is colored WHITE");

			Console.BackgroundColor = ConsoleColor.Magenta;
			Console.WriteLine("The background color is MAGENTA");

			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.WriteLine("The background color is CYAN");

			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.WriteLine("The background color is YELLOW");

			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("The background color is BLACK");
		}
	}
}
