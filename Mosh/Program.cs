using System;

namespace Mosh
{
	public class Program
	{
		static void Main()
		{
			Person john = new Person();
			//john.FirstName = "John";
			//john.LastName = "Smith";
			john.Introduce("John", "Smith");
			//john.Introduce();

			//Arrays

		}
	}

	public class Person
	{
		//public string FirstName;
		//public string LastName;

		public void Introduce(string firstName = "Not", string lastName = "Sure")
		{
			//Console.WriteLine("My name is " + FirstName + " " + LastName);
			Console.WriteLine("My name is " + firstName + " " + lastName);
		}
	}

	public class Arrays
	{
		//Fields	
		private int[] array1;
		private int[] array2 = new int[3];	//Allocating memory of 3 elements

		//Properties
		public int[] Array1
		{
			get { return array1; }
			set { array1 = value;  }
		}

		//Properties
		public int[] Array2
		{
			get { return array1; }
			set { array1 = value; }
		}

		//Constructor
		public Arrays(int[] a1, int[] a2)
		{
			array1 = a1;
			array2 = a2;
		}

	}
}
