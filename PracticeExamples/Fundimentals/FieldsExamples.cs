using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class FieldsExamples
	{
		public static void FieldsExamplesMain()
		{
			Console.WriteLine("\n *********** FIELDS EXAMPLES *********** \n");

		}

		public void NonStaticMethod()
		{
			//Initialize an empty list of 'OrderObject'
			NotInitializedOrders = new List<OrderObject>();
		}

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

		public class OrderObject
		{
			int X { get; set; }
			int Y { get; set; }
		}
	}
}
