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
			Console.WriteLine("refVariableA = " + refVariableA); //Before

			//Method called with 'ref' variable argument
			//- Method can directly changes the variable
			//- No capturing the return and setting 'refVariableA' necessary
			RefModifier(ref refVariableA);

			Console.WriteLine("refVariableA = " + refVariableA); //After
		}

		/////////////////////////////////
		
		public static void RefModifier(ref int refVariableB)
		{
			//'refVariableB' from outside of the method scope is changed
			//- No return necessary
			refVariableB += 22;
		}
	}
}
