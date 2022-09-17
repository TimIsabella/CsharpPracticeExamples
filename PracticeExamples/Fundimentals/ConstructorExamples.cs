using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class ConstructorExamples
	{
		public static void ConstructorExamplesMain()
		{
			Console.WriteLine("\n *********** CONSTRUCTOR EXAMPLES *********** \n");
		}
		
		//Fields
		public int Id;
		public string FieldName;
		public List<OrderObject> Orders;

		//Constructor (no parameters)
		public ConstructorExamples()
		{
			Orders = new List<OrderObject>();
		}

		//Constructor (one parameter)
		//'this' inherits the above constructor (constructor without parameters)
		public ConstructorExamples(int id) : this()
		{
			this.Id = id;
		}

		//Constructor (two parameters)
		//'this' inherits the above constructor (constructor with only one parameter)
		public ConstructorExamples(int id, string constructorParamName) : this(id)
		{
			this.FieldName = constructorParamName;
			this.Id = id;
		}

		public class OrderObject
		{
			int X { get; set; }
			int Y { get; set; }
		}
	}
}
