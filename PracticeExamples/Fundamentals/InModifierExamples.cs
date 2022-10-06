using System;

namespace PracticeExamples
{
	public class InModifierExamples
	{
		public static void InModifierExamplesMain()
		{
			Console.WriteLine("\n *********** In MODIFIER EXAMPLES *********** \n");
			/// In Modifier -- makes parameters read only ///
			
			var inVariableStr = "abc";
			var inVariableInt = 123;
			InModifier(inVariableStr, inVariableInt);
		}

		/////////////////////////////////
		
		public static void InModifier(in string inResultStr, in int inResultInt)
		{
			//in parameters become READONLY so cannot be modified -- the below results in a compile error
			/*
			inResultStr = "xyz";
			inResultInt = 456;
			*/

			Console.WriteLine($"READ ONLY: inResultStr = {inResultStr}, inResultStr = {inResultInt}"); //After
		}
	}
}
