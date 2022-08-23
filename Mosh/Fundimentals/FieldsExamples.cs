using System.Collections.Generic;

namespace Mosh
{
	public class FieldsExamples
	{
		public int Id;
		public string Name;

		public List<OrderObject> NotInitializedOrders; //NOT initialized
		public List<OrderObject> InitializedOrders = new List<OrderObject>(); //Initialized
		public readonly List<OrderObject> ReadOnlyOrders = new List<OrderObject>(); //List is 'readonly'

		public FieldsExamples(int id)
		{
			this.Id = id;
		}

		public FieldsExamples(int id, string name) : this(id)
		{
			//this.Id = id;		//'this(id)' above serves the same purpose by inheritance
			this.Name = name;
		}

		public void FieldsExamplesMain()
		{
			//Initialize an empty list of 'OrderObject'
			NotInitializedOrders = new List<OrderObject>();
		}
		public class OrderObject
		{
			int X { get; set; }
			int Y { get; set; }
		}
	}
}
