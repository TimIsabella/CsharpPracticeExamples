using System;

namespace Mosh
{
	public class EnumExamples
	{
		public static void EnumExamplesMain()
		{
			var enumNumber = RandomEnums.Number3;
			Console.WriteLine($"The enum is {enumNumber}");
		}

		//enum - short for 'enumeration'
		//an array of constants accessed by dot notation
		//Can only be integers
		public enum RandomEnums
		{
			Number1 = 11,
			Number2 = 22,
			Number3 = 33,
			Number4 = 44,
			Number5 = 55,
			Number6 = 66
		}
	}
}
