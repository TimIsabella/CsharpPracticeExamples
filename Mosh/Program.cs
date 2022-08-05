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
			Arrays arr = new Arrays(new int[] { 1, 2, 3 }, new double[] { 4.4, 5.5, 6.6 }, new string[] { "This", "That", "Other" });
			Console.WriteLine(arr.Array1[0] + " " + arr.Array2[1] + " " + arr.Array3[2]);

			Arrays arr2 = new Arrays(new int[0], new double[0], new string[0]);
			arr2.Array1 = new int[] { 11, 22, 33 };
			Console.WriteLine("arr.Array1[0]: " + arr2.Array1[0]);

			//Matrix (Rectangular)
			MatrixSquare matrixSquare = new MatrixSquare(new int[0, 0]);
			matrixSquare.Matrix1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			Console.WriteLine("matrixSquare.Matrix1[2,1]: " + matrixSquare.Matrix1[2,1]);

			//Matrix (Jagged)
			MatrixJagged matrixJagged = new MatrixJagged(new int[0][]);
			matrixJagged.Matrix1 = new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } };
			Console.WriteLine("matrixJagged.Matrix1[1][1]: " + matrixJagged.Matrix1[1][1]);
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
		//Constructor
		public Arrays(int[] a1, double[] a2, string[] a3)
		{
			array1 = a1;
			array2 = a2;
			array3 = a3;
		}

		//Fields	
		private int[] array1;
		private double[] array2 = new double[3];  //Allocating memory of 3 elements
		private string[] array3 = new string[3];

		//Properties
		public int[] Array1
		{
			get { return array1; }
			set { array1 = value; }
		}

		//Properties
		public double[] Array2
		{
			get { return array2; }
			set { array2 = value; }
		}

		//Properties
		public string[] Array3
		{
			get { return array3; }
			set { array3 = value; }
		}
	}

	public class MatrixSquare
	{
		//Constructor
		public MatrixSquare(int[,] m1)
		{
			matrix1 = m1;
		}

		//Fields	
		private int[,] matrix1 = new int[0,0];

		//Properties
		public int[,] Matrix1
		{
			get { return matrix1; }
			set { matrix1 = value; }
		}
	}

	public class MatrixJagged
	{
		//Constructor
		public MatrixJagged(int[][] m1)
		{
			matrix1 = m1;
		}

		//Fields	
		private int[][] matrix1 = new int[0][];

		//Properties
		public int[][] Matrix1
		{
			get { return matrix1; }
			set { matrix1 = value; }
		}
	}
}
