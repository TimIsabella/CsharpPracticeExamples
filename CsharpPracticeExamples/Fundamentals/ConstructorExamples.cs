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
		private double _doubleNumber;

		//Constructor (no parameters)
		public ConstructorExamples()
		{
			Orders = new List<OrderObject>();
		}

		//Constructor (one parameter)
		public ConstructorExamples(int id)
		{
			Id = id;
		}

		//Constructor (two parameters)
		//'this' inherits the above constructor (constructor with only one parameter)
		public ConstructorExamples(int id, string constructorParamName) : this(id)
		{
			FieldName = constructorParamName;

			//This is inherited from the above constructor with the 'id' parameter using 'this'
			//Id = id;
		}

		//Constructor with lambda (one parameter)
		public ConstructorExamples(double doubleNumber) => _doubleNumber = doubleNumber;


		///////////


		public class OrderObject
		{
			int X { get; set; }
			int Y { get; set; }
		}
	}
}
