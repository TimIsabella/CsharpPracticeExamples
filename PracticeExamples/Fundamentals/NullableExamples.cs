using System;

namespace PracticeExamples
{
	public class NullableExamples
	{
		public static void NullableExamplesMain()
		{
			Console.WriteLine("\n *********** NULLABLE EXAMPLES *********** \n");

			/// Value types cannot be null -- Below results in compiler errors ///
			/*
			bool boolNum = null;
			int numberNull = null;
			float floatNull = null;
			char charNull = null;
			DateTime dateTimeNull = null;
			*/

			/// 'Nullable' - wraps types to allow them to be nullable ///
			Nullable<bool> boolNull = null;
			Nullable<int> numberNull = null;
			Nullable <float> floatNull = null;
			Nullable<char> charNull = null;
			Nullable<DateTime> dateTimeNull = null;

			/// Simplified 'Nullable' - Same as above by using a '?' preceeding the type casting ///
			bool? boolNullQ = null;
			int? numberNullQ = null;
			float? floatNullQ = null;
			char? charNullQ = null;
			DateTime? dateTimeNullQ = null;

			/// Cannot create reference to nullable type for non-nullable type --  -- Below results in a compiler error ///
			/*
			bool boolNull2 = boolNull;
			*/

			/// String is a refrence type and is nullable ///
			string stringNull = null;

			/// This works to reference from 'Nullable<>' types ///
			bool boolNull2 = boolNull.GetValueOrDefault();

			/// 'Coalescing' -- '??' is check for null ///
			//- if numberNull is not null, use numberNull, otherwise use '123'
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
