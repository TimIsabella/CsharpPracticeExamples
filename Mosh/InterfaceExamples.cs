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
			var orderProcessor = new OrderProcessor();
			var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
			orderProcessor.Process(order);
		}

		//Interface is declared as 'interface' and no access modifier
		interface IInterfaceExamples
		{

		}

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

	}
}
