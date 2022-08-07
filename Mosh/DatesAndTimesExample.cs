using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class DatesAndTimesExample
	{
		public static void DatesAndTimesMain()
		{
			Console.WriteLine("\n *********** DATES AND TIMES *********** \n");

			//DateTime objects are immutable
			var datTimNow = DateTime.Now;

			Console.WriteLine(datTimNow.Millisecond);
			Console.WriteLine(datTimNow.Second);
			Console.WriteLine(datTimNow.Minute);
			Console.WriteLine(datTimNow.Hour);
			Console.WriteLine(datTimNow.Day);
			Console.WriteLine(datTimNow.Month);

			var datTimToday = DateTime.Today;
			var datTim1 = new DateTime(2022, 1, 11);

			///////////Modifying the time through methods///////////
			
			//Adding and subtracting relative to current time
			Console.WriteLine(datTimToday.AddDays(1)); //Adds 1 day to today
			Console.WriteLine(datTimToday.AddHours(-1)); //Subtracts 1 hour from today

			//Methods for date and time formatting
			Console.WriteLine(datTimNow.ToLongDateString());
			Console.WriteLine(datTimNow.ToShortTimeString());
			Console.WriteLine(datTimNow.ToString("M-dd-fffffff")); //DateTime format specifier


		}
	}
}
