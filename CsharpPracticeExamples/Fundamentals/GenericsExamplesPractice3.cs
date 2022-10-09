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
			private Galaxy<SolarSystem> _galaxySolarSystem;										///Galaxy takes a generic of 'SolarSystem' which does not take a generic
			private Galaxy<SolarSystem<Planet>> _galaxySolarSystemPlanet;						///Galaxy takes a generic of 'SolarSystem<>' which DOES take a generic
			private Galaxy<SolarSystem<Planet<Satellite>>> _galaxySolarSystemPlanetSatellite;

			public Galaxy GalaxyMethod()
			{
				_galaxy = new Galaxy();
				return _galaxy;
			}

			public Galaxy<SolarSystem> SolarSystemMethod()
			{
				_galaxySolarSystem = new Galaxy<SolarSystem>();
				return _galaxySolarSystem;
			}

			public Galaxy<SolarSystem<Planet>> PlanetMethod()
			{
				_galaxySolarSystemPlanet = new Galaxy<SolarSystem<Planet>>();
				return _galaxySolarSystemPlanet;
			}

			public Galaxy<SolarSystem<Planet<Satellite>>> SatelliteMethod()
			{
				_galaxySolarSystemPlanetSatellite = new Galaxy<SolarSystem<Planet<Satellite>>>();
				return _galaxySolarSystemPlanetSatellite;
			}
		}

		///Need both non-generic and generic class combinations to complete the above
		///- Classes cannot be used interchangeable for generic and non-generic

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

		public class Planet<T>
		{ }

		public class Satellite
		{ }
	}
}
