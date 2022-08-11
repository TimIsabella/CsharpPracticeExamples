using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class ConstructorExampleAdvanced
	{
		public static void ConstructorExampleAdvancedMain()
		{
			Console.WriteLine("\n *********** CONSTRUCTOR ADVANCED *********** \n");

			//Base 'Vehicle class' will be executed first
			//Derived 'Car class' will be executed second
			var car1 = new Car();
			var car2 = new Car("123CarReg");
		}

		//Two different constructors - One parameterless and one with a single parameter
		public class Vehicle
		{
			private string _registrationNumber;

			//Parameterless
			public Vehicle()
			{
				Console.WriteLine("Paramaterless vehicle constructor...");
			}

			//Single parameter
			public Vehicle(string registrationNumber)
			{
				_registrationNumber = registrationNumber;
				Console.WriteLine("Vehicle of registration '{0}' is being initialized", registrationNumber);
			}
		}

		//Two different constructors - One parameterless and one with a single parameter (matching 'base' derived class)
		public class Car : Vehicle	//Car inherits from Vehicle
		{
			//Parameterless
			public Car() 
			{ }

			//Single parameter
			//'Base' refers to derived inherited class constructor
			//Argument will be passed to both parameters -- first to base and then to derived
			public Car(string registrationNumber) : base(registrationNumber)
			{
				Console.WriteLine("Car of registration '{0}' is being initialized", registrationNumber);
			}
		}
	}
}
