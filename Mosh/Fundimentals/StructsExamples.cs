using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class StructsExamples
	{
		public static void StructsExamplesMain()
		{
			Console.WriteLine("\n *********** STRUCTS *********** \n");

			var position = new Position();
			position.X = 1.234f; position.Y = 2.345f; position.Z = 3.456f;
			position.GetPosition();
		}

		//Short for 'structure' and very similar to classes
		//Used to store commonly used values
		//Structs CANNOT inherit

		//Structs are 'value types' whereas classes are 'reference types'
		//Class reference type -- value1 copied to value2 creates a reference to value1, so changing value1 changes value2.
		//Struct value type -- value1 copied to value2 creates a true copy for value2 and is not affected by changes to value1.

		public struct RGBcolor
		{
			public int Red;
			public int Green;
			public int Blue;
		}

		public struct Position
		{
			public float X;
			public float Y;
			public float Z;

			public void GetPosition()
			{ Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}"); }
		}
	}
}
