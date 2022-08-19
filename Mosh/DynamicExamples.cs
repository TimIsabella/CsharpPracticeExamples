using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class DynamicExamples
	{
		public static void DynamicExamplesMain()
		{
			Console.WriteLine("\n *********** DYNAMIC *********** \n");

			//Language types
			//Static Languages: type resolution is established at compile-time (C#, Java)
			//Dynamic languages: type resolution is established at run-time (JavaScript, Python)

			//.NET version 4 added 'dynamic' capability
			//Allows usage of variables to change cast like dynamic languages (JavaScript, Python)

			dynamic name = "This is a name";
			Console.WriteLine($"name: {name}");
			name = 10;
			Console.WriteLine($"name: {name}");
			name = 1.618;
			Console.WriteLine($"name: {name}");

			dynamic number = 123;
			Console.WriteLine($"number: {number}");
			number = "One Two Three";
			Console.WriteLine($"number: {number}");
			number = true;
			Console.WriteLine($"number: {number}");


			dynamic boolVar = false;
			Console.WriteLine($"boolVar: {boolVar}");
			boolVar = 123 + "123";
			Console.WriteLine($"boolVar: {boolVar}");
			boolVar = "this is not a bool";
			Console.WriteLine($"boolVar: {boolVar}");
		}
	}
}
