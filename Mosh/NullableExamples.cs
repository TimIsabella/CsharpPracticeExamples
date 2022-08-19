using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class NullableExamples
	{
		public static void NullableExamplesMain()
		{
			Console.WriteLine("\n *********** NULLABLE *********** \n");

			///Value types cannot be null///
			/*
			//Error: cannot be null
			bool boolNum = null;
			int numberNull = null;
			float floatNull = null;
			char charNull = null;
			DateTime dateTimeNull = null;
			*/

			//'Nullable' - wraps types to allow them to be nullable
			Nullable<bool> boolNull = null;
			Nullable<int> numberNull = null;
			Nullable <float> floatNull = null;
			Nullable<char> charNull = null;
			Nullable<DateTime> dateTimeNull = null;

			//String is a refrence type and is nullable
			string stringNull = null;

			Console.WriteLine("boolNull: {0}", boolNull == null ? "Null" : "Not Null");
			Console.WriteLine("numberNull: {0}", numberNull == null ? "Null" : "Not Null");
			Console.WriteLine("floatNull: {0}", floatNull == null ? "Null" : "Not Null");
			Console.WriteLine("charNull: {0}", charNull == null ? "Null" : "Not Null");
			Console.WriteLine("dateTimeNull: {0}", dateTimeNull == null ? "Null" : "Not Null");
			Console.WriteLine("dateTimeNull: {0}", dateTimeNull == null ? "Null" : "Not Null");
			Console.WriteLine("stringNull: {0}", stringNull == null ? "Null" : "Not Null");
		}
	}
}
