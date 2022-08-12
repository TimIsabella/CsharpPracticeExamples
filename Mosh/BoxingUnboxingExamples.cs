using System;
using System.Collections;
using System.Collections.Generic;

namespace Mosh
{
	public class BoxingUnboxingExamples
	{
		public void BoxingUnboxingExamplesMain()
		{
			Console.WriteLine("\n *********** BOXING AND UNBOXING *********** \n");

			//Boxing - Converting a type to an object //
			int number = 10;			//Stored in the 'stack' as a reference
			object boxedObj1 = number;  //'boxedObj1' stored in the 'stack' as a reference while 'number' stored in the 'heap' 
			object boxedObj2 = 10;      //'boxedObj2' stored in the 'stack' as a reference while '10' stored in the 'heap'

			//Unboxing
			int unboxedNum = (int)boxedObj1;
			int unboxedNum2 = (int)boxedObj2;

			//Boxing
			var list = new ArrayList(); //Not typesafe
			list.Add(1);
			list.Add("Whatever");
			list.Add(DateTime.Now);

			//Unboxing
			var numberFromList = (int)list[1];

			//Unboxing
			var genericsList = new List<int>(); //Typesafe
			var names = new List<string>();     //Typesafe
		}
		
	}
}
