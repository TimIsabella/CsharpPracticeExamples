using System;

namespace PracticeExamples
{
	public class OutModifierExamples
	{
		public static void OutModifierExamplesMain()
		{
			Console.WriteLine("\n *********** OUT MODIFIER EXAMPLES *********** \n");
			/// Out Modifier -- replaces the argument variable in line with the parameter ///
			
			var outVariableStr = "abc";
			var outVariableInt = 123;
			Console.WriteLine($"outVariable = {outVariableStr}, outVariableInt = {outVariableInt}"); //Before

			//Method called with 'out' variable argument
			//- Method REPLACES the variables in the argument with those from within the method
			//- Arguments ARE NOT passed into the method
			OutModifier(out outVariableStr, out outVariableInt);

			Console.WriteLine($"outVariable = {outVariableStr}, outVariableInt = {outVariableInt}"); //After
		}

		/////////////////////////////////
		
		public static void OutModifier(out string outResultStr, out int outResultInt)
		{
			//out parameters set to values
			outResultStr = "xyz";
			outResultInt = 456;
		}
	}
}
