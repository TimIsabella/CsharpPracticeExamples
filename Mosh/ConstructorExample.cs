using System.Collections.Generic;

namespace Mosh
{
	public class ConstructorExample
	{
		//Fields
		public int Id;
		public string FieldName;
		public List<Order> Orders;

		//Constructor (no parameters)
		public ConstructorExample()
		{
			Orders = new List<Order>();
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
	}
}
