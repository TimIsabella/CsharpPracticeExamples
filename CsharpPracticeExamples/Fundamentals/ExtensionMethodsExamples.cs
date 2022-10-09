using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class ExtensionMethodsExamples
	{
		public static void ExtensionMethodsExamplesMain()
		{
			Console.WriteLine("\n *********** EXTENSIONS EXAMPLES *********** \n");

			string wordsString = "These are words";
			var convertWords = wordsString.ConvertTheseWordsMethod(123456);

			Console.WriteLine($"Converted words: {convertWords}");
		}
	}

	//Extends custom methods to instance members
	//- Class and method must be 'public' and 'static'
	//- First argument must be 'this' representing the instance for which it is applied
	public static class Extension
	{
		public static string ConvertTheseWordsMethod(this string words, int nums)
		{
			return $"{words} {nums.ToString()}";
		}
	}
}
