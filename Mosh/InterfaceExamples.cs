using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			//Explicit implementation
			IAircraft rocketMaxAltitude = new Rocket(); rocketMaxAltitude.MaxAltitude(100000);
			IAircraft.IColor rocketColor = new Rocket(); rocketColor.Color("White");
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

		//Properties
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
			public void Weight(int pounds)
			{ Console.WriteLine("Helicopter weight: {0} lbs", pounds); }
			public string PassengerCapacity(int quantity)
			{ Console.WriteLine("Helicopter passenger capacity: {0}", quantity); return "Return string"; }
			public void MaxAltitude(int altitude)
			{ Console.WriteLine("Helicopter maximum altitude: {0} ft", altitude); }
			public string FuelType { get; set; }
			public float FuelBurnRate { get; set; }
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

		///////////////////////////////////////////////////////////////////////////////////////////////////


		/*
		public static void InterfaceExamplesMain()
		{
			var orderProcessor = new OrderProcessor();
			var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
			orderProcessor.Process(order);
		}

		//Interface is declared as 'interface' and no access modifier
		interface IInterfaceExamples
		{

		}

		///////////////////////////////// Unit Test Code for Interface Below /////////////////////////////////

		public class OrderProcessor
		{
			private readonly ShippingCalculator _shippingCalculator;

			public OrderProcessor()
			{ _shippingCalculator = new ShippingCalculator(); }

			public void Process(Order order)
			{
				if(order.IsShipped) throw new InvalidOperationException("This order is already processed.");
				order.Shipment = new Shipment { Cost = _shippingCalculator.CalculateShipping(order), ShippingDate = DateTime.Today.AddDays(1) };
			}
		}

		public class ShippingCalculator
		{
			public float CalculateShipping(Order order)
			{ 
				if(order.TotalPrice < 30f) return order.TotalPrice * 0.1f; 
				else return 0; 
			}
		}

		public class Shipment
		{
			public float Cost { get; set; }
			public DateTime ShippingDate { get; set; }
		}

		public class Order
		{
			public int Id { get; set; }
			public DateTime DatePlaced { get; set; }
			public Shipment Shipment { get; set; }
			public float TotalPrice { get; set; }
			
			public bool IsShipped
			{
				get { return Shipment != null; }
			}
		}
		*/
	}
}
