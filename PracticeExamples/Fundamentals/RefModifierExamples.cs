using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class RefModifierExamples
	{
		public static void RefModifierExamplesMain()
		{
			Console.WriteLine("\n *********** REF MODIFIER EXAMPLES *********** \n");

			//Ref
			var refVariableA = 11;
			Console.WriteLine("refVariableA = " + refVariableA); //Before
			RefModifier(ref refVariableA);
			Console.WriteLine("refVariableA = " + refVariableA); //After
		}

		/////////// Ref modifier -- directly changes the variable reference ///////////
		public static void RefModifier(ref int refVariableB)
		{
			refVariableB += 22;
		}
	}
}
