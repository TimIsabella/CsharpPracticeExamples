using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class GenericsExamplesPractice2
	{
		public static void GenericsExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** GENERICS EXAMPLES PRACTICE 2 *********** \n");

			int[] intArray = { 1, 2, 3 };
			double[] doubleArray = { 1.1, 2.2, 3.3 };
			string[] stringArray = { "one", "two", "three" };

			DisplayElements(intArray, doubleArray, stringArray);

			DisplayElementsGeneric(intArray);
			DisplayElementsGeneric(doubleArray);
			DisplayElementsGeneric(stringArray);

			//Cannot pass in multiple types as generic, only one type at a time
			DisplayElementsGenericMultiple(intArray, null, null);
			DisplayElementsGenericMultiple(null, doubleArray, null);
			DisplayElementsGenericMultiple(null, null, stringArray);
		}

		public static void DisplayElements(int[] intA, double[] dubA, string[] strA)
		{
			foreach(int i in intA)
			{ Console.WriteLine(i); }
		}

		public static void DisplayElementsGeneric<T>(T[] thing)
		{
			foreach(T i in thing)
			{ Console.WriteLine(i); }
		}

		public static void DisplayElementsGenericMultiple<T>(T[] intA, T[] dubA, T[] strA)
		{
			if(intA != null)
			{ 
				foreach(T i in intA)
				{ Console.WriteLine($"intA: {i}"); }
			}

			if(dubA != null)
			{
				foreach(T i in dubA)
				{ Console.WriteLine($"dubA: {i}"); }
			}

			if(strA != null)
			{
				foreach(T i in strA)
				{ Console.WriteLine($"strA: {i}"); }
			}
		}
	}
}
