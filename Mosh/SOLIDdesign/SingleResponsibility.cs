using System;
using System.Collections.Generic;
using System.IO;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class SingleResponsibility
	{
		public static void SingleResponsibilityMain()
		{
			Console.WriteLine("\n *********** SINGLE RESPONSIBILITY PRINCIPAL *********** \n");

			var journal = new Journal();

			journal.AddEntry("I was happy today");
			journal.AddEntry("Today I ate a bug");
			journal.AddEntry("This will be my final entry");
			journal.AddEntry("OMG a thing happened!");

			Console.WriteLine(journal);

			var persist = new Persistence();
			var filename = @"D:\journalTest.txt";
			persist.SaveToFile(journal, filename, true);
		}

		/// ///////////////////////////////// Single Responsibility  /////////////////////////////////
		//- The necessary object should handle the necessary function and not be mixed together
		//- A 'separation of concerns'

		public class Journal
		{
			private readonly List<string> _entries = new List<string>();
			private static int count = 0;

			public int AddEntry(string text)
			{
				_entries.Add($"{++count}: {text}");
				return count;
			}

			public void RemoveEntry(int index)
			{
				_entries.RemoveAt(index);
			}

			public override string ToString()
			{
				return string.Join(Environment.NewLine, _entries);
			}
		}

		///////////////////////////////// Persistence /////////////////////////////////
		//- An object which handles generic functionality to be used by other objects
		//- The below can be used for file saving by the 'Journal' object or any other object with similar makeup

		public class Persistence
		{
			public void SaveToFile(object objectParam, string filename, bool overwrite = false)
			{
				if(overwrite || !File.Exists(filename))
				{ File.WriteAllText(filename, objectParam.ToString()); }
			}
		}
	}
}
