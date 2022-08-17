using System;

namespace Mosh
{
	public class LambdaExamples
	{
		public void LambdaExamplesMain()
		{
			Console.WriteLine("\n *********** LAMBDA EXAMPLES *********** \n");

			Console.WriteLine(Multiply(123, 456, 789));

			//Same as above using lambda
			//'Func' delagate
			Func<int, int, int, int> multiplyByDelegate = (num1, num2, num3) => num1 * num2 * num3;
			Console.WriteLine(multiplyByDelegate(123, 456, 789));
		}

		public static int Multiply(int num1, int num2, int num3)
		{
			return num1 * num2 * num3;
		}
	}
}
