using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples
{
	public class AbstractExamplesPractice3
	{
		public static void AbstractExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** ABSTRACT EXAMPLES PRACTICE 3 *********** \n");

			var dwellings = new List<Building>();

			dwellings.Add(new House());
			dwellings.Add(new Condo());
			dwellings.Add(new Apartment());

			dwellings[0].Roof();
			dwellings[1].Roof();
			dwellings[2].Roof();
		}

		/////////// Base abstract class ///////////
		public abstract class Building
		{
			public abstract void Windows();
			public abstract void Doors();
			public abstract void Roof();
		}

		/////////// Override classes ///////////
		public class House : Building
		{
			public override void Windows()
			{ }
			public override void Doors()
			{ }
			public override void Roof()
			{ Console.WriteLine("The roof is covered in shingles."); }
		}

		public class Condo : Building
		{
			public override void Windows()
			{ }
			public override void Doors()
			{ }
			public override void Roof()
			{ Console.WriteLine("The roof is covered in tile."); }
		}

		public class Apartment : Building
		{
			public override void Windows()
			{ }
			public override void Doors()
			{ }
			public override void Roof()
			{ Console.WriteLine("The roof is covered in tar paper."); }
		}
	}
}
