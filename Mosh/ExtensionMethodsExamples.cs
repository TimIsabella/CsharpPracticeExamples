using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class ExtensionMethodsExamples
	{
		public static void ExtensionMethodsExamplesMain()
		{
			string words = "These are words";
			var convertWords = words.ConvertTheseWordsMethod(123);

			Console.WriteLine($"Converted words: {convertWords}");
		}
	}

	//Extend methods to
	//- Class and method must be 'public' and 'static'
	//- First argument must be 'this' represending the instance for which it is applied
	public static class Extension
	{
		public static string ConvertTheseWordsMethod(this string words, int nums)
		{
			return words + nums.ToString();
		}
	}
}
