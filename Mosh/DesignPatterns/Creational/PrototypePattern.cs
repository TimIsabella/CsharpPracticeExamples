using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
	public class PrototypePattern
	{
		public static void PrototypeMain()
		{
			Console.WriteLine("\n *********** PROTOTYPE PATTERN *********** \n");
			/// Specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype
			/// - Creates clones of the output

			// Create two instances and clone each
			ConcretePrototype1 prototype1 = new ConcretePrototype1("Prototype Number 1");
			ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();
			Console.WriteLine($"Cloned: {clone1.Id}");

			ConcretePrototype2 prototype2 = new ConcretePrototype2("Prototype Number 2");
			ConcretePrototype2 clone2 = (ConcretePrototype2)prototype2.Clone();
			Console.WriteLine($"Cloned: {clone2.Id}");
		}

		//Prototype (abstract container)
		public abstract class Prototype
		{
			private string _id;

			public Prototype(string id)
			{ _id = id; }

			public string Id { get { return _id; } }

			public abstract Prototype Clone();
		}

		//Concrete Prototype
		public class ConcretePrototype1 : Prototype
		{
			public ConcretePrototype1(string id) : base(id) //'base()' inherits from 'Prototype' as the constructor and the 'Id' parameter
			{ }

			//Returns a shallow copy of 'this' object
			public override Prototype Clone()
			{ return this; }
		}

		//Concrete Prototype
		public class ConcretePrototype2 : Prototype
		{
			public ConcretePrototype2(string id) : base(id)
			{ }

			//Returns a shallow copy of 'this' object
			public override Prototype Clone()
			{ return this; }
		}
	}
}
