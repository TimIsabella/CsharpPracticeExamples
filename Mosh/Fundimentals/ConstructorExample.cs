using System.Collections.Generic;

namespace PracticeExamples
{
	public class ConstructorExample
	{
		//Fields
		public int Id;
		public string FieldName;
		public List<OrderObject> Orders;

		//Constructor (no parameters)
		public ConstructorExample()
		{
			Orders = new List<OrderObject>();
		}

		//Constructor (one parameter)
		//'this' inherits the above constructor (constructor without parameters)
		public ConstructorExample(int id) : this()
		{
			this.Id = id;
		}

		//Constructor (two parameters)
		//'this' inherits the above constructor (constructor with only one parameter)
		public ConstructorExample(int id, string constructorParamName) : this(id)
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
