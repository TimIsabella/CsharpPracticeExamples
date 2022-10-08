using System;
using System.Collections.Generic;
using static PracticeExamples.GenericsExamplesPractice3;

namespace PracticeExamples
{
	public class GenericsExamplesPractice3
	{
		public static void GenericsExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** GENERICS EXAMPLES PRACTICE 3 *********** \n");
			
		}

		//////////////////////////////////////////////////////////////////

		public class Generic
		{
			private Galaxy _galaxy;
			private Galaxy<SolarSystem> _galaxyWithSolarSystem;                     ///Galaxy takes a ganeric of 'SolarSystem' which does not take a generic
			private Galaxy<SolarSystem<Planet>> _galaxyWithSolarSystemAndPlanet;    ///Galaxy takes a ganeric of 'SolarSystem' which DOES take a generic

			public Galaxy GalaxyMethod()
			{
				_galaxy = new Galaxy();
				return _galaxy;
			}

			public Galaxy<SolarSystem> SolarSystemMethod()
			{
				_galaxyWithSolarSystem = new Galaxy<SolarSystem>();
				return _galaxyWithSolarSystem;
			}

			public Galaxy<SolarSystem<Planet>> PlanetMethod()
			{
				_galaxyWithSolarSystemAndPlanet = new Galaxy<SolarSystem<Planet>>();
				return _galaxyWithSolarSystemAndPlanet;
			}
		}

		///Need both non-generic and generic class combinations to complete the above

		public class Galaxy
		{ }

		public class Galaxy<T>
		{ }

		public class SolarSystem
		{ }

		public class SolarSystem<T>
		{ }

		public class Planet
		{ }
	}
}
