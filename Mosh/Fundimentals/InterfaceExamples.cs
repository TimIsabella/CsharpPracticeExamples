using System;

namespace Mosh
{
	public class InterfaceExamples
	{
		public static void InterfaceExamplesMain()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES *********** \n");

			//Regular implementation
			Car car = new Car(); car.Weight(2000);

			Helicopter helicopter = new Helicopter(); helicopter.MaxAltitude(20000);
			helicopter.FuelType = "JP8"; Console.WriteLine("Helicopter: {0}", helicopter.FuelType);
			helicopter.FuelBurnRate = 234.56f; Console.WriteLine($"Helicopter: Burn rate is {helicopter.FuelBurnRate}");

			Rocket rocket = new Rocket();
			rocket.FuelType = "Solid"; Console.WriteLine("Rocket fuel type: {0}", rocket.FuelType);
			rocket.FuelBurnRate = 1234.567f; Console.WriteLine($"Rocket: Burn rate is {rocket.FuelBurnRate}");

			//Explicit implementation
			IAircraft rocketMaxAltitude = new Rocket(); rocketMaxAltitude.MaxAltitude(100000);
			IAircraft.IColor rocketColor = new Rocket(); rocketColor.Color("White");

			//Mixed types
			Bird bird = new Bird();
			bird.FuelType = "Birdseed"; Console.WriteLine($"The bird is fuled by {bird.FuelType}");
			Console.WriteLine("The bird is traveling a " + bird.VectorDegrees(123.4f));
			IAircraft.IColor birdColor = new Bird(); birdColor.Color("Blue");
		}

		//An interface is a 'contract' to provide explicit functionality
		//- provides security that explicit access
		//- provides encapsulation by hiding details
		//- Declared as 'interface' and no access modifier
		//- Only contains decalarations
		interface IVehicle
		{
			//Interface methods are public and MUST match those implimenting it
			//Can only contain properties or methods
			void Weight(int lbs);
			string PassengerCapacity(int qty);
		}

		//Interface with properties
		interface IFuel
		{
			string FuelType { get; set; }
			float FuelBurnRate { get; set; }
		}

		interface IAircraft
		{
			void MaxAltitude(int alt);

			//Nested interface
			interface IColor
			{
				int Color(string color);
			}
		}

		public class Car : IVehicle //Implementing the 'IVehicle' interface
		{
			//Methods and return types must match the interface
			public void Weight(int pounds)
			{ Console.WriteLine("Car weight: {0} lbs", pounds); }
			public string PassengerCapacity(int quantity)
			{ Console.WriteLine("Car passenger capacity: {0}", quantity); return "Return string"; }
		}

		public class Helicopter : IAircraft, IFuel //Multiple interface inheritance
		{
			private string _fuelType;
			private float _fuelBurnRate;
			public void Weight(int pounds)
			{ Console.WriteLine("Helicopter weight: {0} lbs", pounds); }
			public string PassengerCapacity(int quantity)
			{ Console.WriteLine("Helicopter passenger capacity: {0}", quantity); return "Return string"; }
			public void MaxAltitude(int altitude)
			{ Console.WriteLine("Helicopter maximum altitude: {0} ft", altitude); }
			public string FuelType
			{
				get { return "The fuel type is " + _fuelType; }
				set { _fuelType = value; }
			}
			public float FuelBurnRate
			{
				get { return _fuelBurnRate + 123.45f; }
				set { _fuelBurnRate = value; }
			}
		}

		public class Rocket : IAircraft, IFuel, IAircraft.IColor //Nested interface usage
		{
			public string FuelType { get; set; }
			public float FuelBurnRate { get; set; }

			//Explicit interface implementation (cannot use access modifier)
			void IAircraft.MaxAltitude(int altitude)
			{ Console.WriteLine("Rocket maximum altitude: {0} ft", altitude); }
			int IAircraft.IColor.Color(string color)
			{ Console.WriteLine("Rocket color: {0}", color); return 123;  }
		}

		public class Bird : Vector, IFuel, IAircraft.IColor //Mixed types (can only inherit one object base, and must come first)
		{
			public string FuelType { get; set; }
			public float FuelBurnRate { get; set; }
			int IAircraft.IColor.Color(string color)
			{ Console.WriteLine("Bird color: {0}", color); return 123; }
		}

		public class Vector
		{
			public string VectorDegrees(float deg)
			{
				return ($"vector of {deg} degrees").ToString();
			}
		}
	}
}
