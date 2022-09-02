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
			Console.WriteLine("\n *********** EXTENSIONS *********** \n");

			string words = "These are words";
			var convertWords = words.ConvertTheseWordsMethod(123456);

			Console.WriteLine($"Converted words: {convertWords}");
		}
	}

	//Extends custom methods to instance members
	//- Class and method must be 'public' and 'static'
	//- First argument must be 'this' represending the instance for which it is applied
	public static class Extension
	{
		public static string ConvertTheseWordsMethod(this string words, int nums)
		{
			return $"{words} {nums.ToString()}";
		}
	}
}
