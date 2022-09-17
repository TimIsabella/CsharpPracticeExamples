using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class NullableExamples
	{
		public static void NullableExamplesMain()
		{
			Console.WriteLine("\n *********** NULLABLE EXAMPLES *********** \n");

			///Value types cannot be null///
			/*
			//ERROR: cannot be null
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

			/*
			//ERROR: cannot create reference to nullable type for non-nullable type
			bool boolNull2 = boolNull;
			*/
			
			//This works to reference from nullable types
			bool boolNull2 = boolNull.GetValueOrDefault();

			//'Coalescing' -- double ?? is check for null
			//if numberNull is not null, use numberNull, otherwise use 123
			int numberNull2 = numberNull ?? 123;

			//////////////////////////////////////////////////////////////////

			Console.WriteLine("boolNull: {0}", boolNull == null ? "Null" : "Not Null");
			Console.WriteLine("numberNull: {0}", numberNull == null ? "Null" : "Not Null");
			Console.WriteLine("floatNull: {0}", floatNull == null ? "Null" : "Not Null");
			Console.WriteLine("charNull: {0}", charNull == null ? "Null" : "Not Null");
			Console.WriteLine("dateTimeNull: {0}", dateTimeNull == null ? "Null" : "Not Null");
			Console.WriteLine("dateTimeNull: {0}", dateTimeNull == null ? "Null" : "Not Null");
			Console.WriteLine("stringNull: {0}", stringNull == null ? "Null" : "Not Null");

			Console.WriteLine("boolNull.GetValueOrDefault(): {0}", boolNull.GetValueOrDefault());
			Console.WriteLine("boolNull.HasValue: {0}", boolNull.HasValue);

			Console.WriteLine("Coalescing -- floatNull ?? 1.618: {0}", floatNull ?? 1.618);
		}
	}
}
