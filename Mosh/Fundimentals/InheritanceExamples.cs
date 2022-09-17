using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class InheritanceExamples
	{
		public static void InheritanceExamplesMain()
		{
			Console.WriteLine("\n *********** INHERITANCE EXAMPLES *********** \n");

			var text = new Text();
			text.Width = 123;
			text.Copy();
		}

		public class Text : PresentationObject
		{
			public int FontSize { get; set; }
			public string FontName { get; set; }

			public void AddHyperlink(string url)
			{
				Console.WriteLine("Link added: " + url);
			}
		}

		public class PresentationObject
		{
			public int Width { get; set; }
			public int Height { get; set; }

			public void Copy()
			{
				Console.WriteLine("Object Copied");
			}

			public void Duplicate()
			{
				Console.WriteLine("Object Duplicated");
			}
		}


	}
}
