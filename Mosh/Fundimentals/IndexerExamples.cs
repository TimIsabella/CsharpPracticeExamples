using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class IndexerExamples
	{
		public Dictionary<string, string> Dictionary1;
		public Dictionary<string, string> Dictionary2 = new Dictionary<string, string>(); //Initialized

		public static void IndexerExamplesMain()
		{
			Console.WriteLine("\n *********** INDEXER *********** \n");

			var dict = new IndexerExamples();
			dict["name"] = "Rupert";
			dict["species"] = "Dog";
			dict["size"] = "Large";
			Console.WriteLine("{0} is a {1} of size {2}", dict["name"], dict["species"], dict["size"]);
		}

		public IndexerExamples()
		{
			Dictionary1 = new Dictionary<string, string>(); //Initialized within constructor
		}

		//Indexer property
		public string this[string key]
		{
			get { return Dictionary1[key];  }
			set { Dictionary1[key] = value; }
		}
	}
}
