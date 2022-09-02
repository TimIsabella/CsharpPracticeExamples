using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class SingleResponsibility
	{
		public static void SingleResponsibilityMain()
		{
			var journal = new Journal();

			journal.AddEntry("I was happy today");
			journal.AddEntry("I ate a bug");

			Console.WriteLine(journal);
		}
	}

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
}
