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
			name = true;
			Console.WriteLine($"name: {name}");

			dynamic boolVar = false;
			Console.WriteLine($"boolVar: {boolVar}");
			boolVar = 123 + "123";
			Console.WriteLine($"boolVar: {boolVar}");

			int num1 = 11;
			var num2 = 22;
			dynamic result1;		//dynamic can be initialized without a value
			result1 = num1 + num2;
			Console.WriteLine($"Result1: {result1}");

			dynamic num3 = 111;
			int num4 = 222;
			var result2 = num3 + num4;		//By using by including a 'dynamic' variable, 'var' becomes 'dynamic'
			Console.WriteLine($"Result2: {result2}");
		}
	}
}
