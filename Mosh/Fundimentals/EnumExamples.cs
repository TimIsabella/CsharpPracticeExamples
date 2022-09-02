using System;

namespace PracticeExamples
{
	public class EnumExamples
	{
		public static void EnumExamplesMain()
		{
			var enumNumber = RandomEnumsWithIntegers.Number3;
			Console.WriteLine($"The enum is {enumNumber}");
		}

		//enum - short for 'enumeration'
		//an array of constants accessed by dot notation
		//Can only contain integers or empty
		public enum RandomEnumsWithIntegers
		{
			Number1 = 11,
			Number2 = 22,
			Number3 = 33,
			Number4 = 44,
			Number5 = 55,
			Number6 = 66
		}

		public enum Seasons
		{
			Spring,
			Summer,
			Fall,
			Winter
		}
	}
}
