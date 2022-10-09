using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class RefModifierExamples
	{
		public static void RefModifierExamplesMain()
		{
			Console.WriteLine("\n *********** REF MODIFIER EXAMPLES *********** \n");
			/// Ref modifier -- directly changes the variable reference ///
			
			var refVariableA = 11;
			Console.WriteLine("BEFORE: refVariableA = " + refVariableA);

			//Method called with 'out' variable argument
			//- Method PASSES IN the refrence variable which can be CHANGED DIRECTLY by the method
			//- Capturing a return and setting 'refVariableA' is not necessary
			RefModifier(ref refVariableA);

			Console.WriteLine("AFTER: refVariableA = " + refVariableA);
		}

		/////////////////////////////////
		
		public static void RefModifier(ref int refVariableB)
		{
			//'refVariableB' passed into the method is directly modified
			//- No return necessary
			refVariableB += 22;
		}
	}
}
