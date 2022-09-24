using System;

namespace PracticeExamples
{
	public class TimeSpanExamples
	{
		public static void TimeSpanMain()
		{
			Console.WriteLine("\n *********** TIME SPAN EXAMPLES *********** \n");

			//1 hour, 2 minutes, 3 seconds
			var timSpa1 = new TimeSpan(1, 2, 3);
			Console.WriteLine(timSpa1);

			//1 hour, 0 minutes, 0 seconds
			var timSpa2 = new TimeSpan(1, 0, 0);
			Console.WriteLine(timSpa2);

			//1 hour
			var timSpa3 = TimeSpan.FromHours(1);
			Console.WriteLine(timSpa3);

			//Total
			Console.WriteLine("timSpa1 minutes total: " + timSpa1.TotalMinutes);

			//Add
			Console.WriteLine("timSpa + 11 minutes: " + timSpa1.Add(TimeSpan.FromMinutes(11)));

			//Parse() -- create TimeSpan from string
			string timeSpanToParse = "01:02:03";
			Console.WriteLine("Parse: " + TimeSpan.Parse(timeSpanToParse));
		}

		public static TimeSpan TimeSpanHour(int a)
		{
			return TimeSpan.FromHours(a);
		}
	}
}