using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class GenericsExamplesPractice2
	{
		public static void GenericsExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** GENERICS EXAMPLES PRACTICE 2 *********** \n");

			var genericClass = new GenericsClass();
			genericClass.OutputGeneric("string");
			genericClass.OutputGenericArray(new int[] { 1, 2, 3 });
			genericClass.OutputGenericMultiple(1.618, new double[] { 1.23, 4.56, 7.89 });
		}

		//////////////////////////////////////////////////////////////////

		class GenericsClass
		{
			//'T' is the name for a generic type to be used
			public void OutputGeneric<T>(T genericT)
			{ Console.WriteLine($"OutputGeneric T genericT: {genericT}"); }

			//The generic type can be named anything
			public void OutputGenericArray<Z>(Z[] genericZarray)
			{ 
				foreach(Z i in genericZarray)
				{ Console.WriteLine($"OutputGenericArray T[] genericT: {i}"); }
			}

			//The type is cast as only ONE type
			//- In the below case, both parameters must be the same type
			public void OutputGenericMultiple<Thing>(Thing genericThing, Thing[] genericThingArray)
			{
				Console.WriteLine($"OutputGenericMultiple Thing genericThing: {genericThing}");

				foreach(Thing i in genericThingArray)
				{ Console.WriteLine($"OutputGenericMultiple Thing[] genericThingArray: {i}"); }
			}
		}
		
	}
}
