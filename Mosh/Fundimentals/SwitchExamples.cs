using System;

namespace PracticeExamples
{
	public class SwitchExamples
	{
		public static void SwitchExamplesMain()
		{
			Console.WriteLine("\n *********** SWITCH EXAMPLES *********** \n");

			var season = Seasons.Fall;

			switch(season)
			{
				case Seasons.Spring:
					Console.WriteLine("It is spring!");
					break;
				case Seasons.Summer:
					Console.WriteLine("It is summer...");
					break;
				case Seasons.Fall:
					Console.WriteLine("It is fall!");
					break;
				case Seasons.Winter:
					Console.WriteLine("It is winter!");
					break;

				default:
					Console.WriteLine("That is not a season");
					break;
			}
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
