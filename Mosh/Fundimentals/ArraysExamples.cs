using System;

namespace Mosh
{
	public class ArraysExamples
	{
		public static void ArraysMain()
		{
			Console.WriteLine("\n *********** ARRAYS *********** \n");
			
			//Array
			int[] arr1 = new int[] { 1, 2, 3, };
			Console.WriteLine("arr1[2]: " + arr1[2]);

			//Array
			var arr2 = new[] { 11, 22, 33 };
			Console.WriteLine("arr2[1]: " + arr2[1]);
			
			///////////Array instance memebers: accessable for objects///////////

			//Array Length
			Console.WriteLine("arr2 Length: " + arr1.Length + " elements");

			//Array IsReadOnly
			Console.WriteLine("arr2 IsReadOnly: " + arr1.IsReadOnly);

			///////////Array static methods: accessable by class///////////

			//Array IndexOf()
			Console.WriteLine("arr2 IndexOf() '3': " + Array.IndexOf(arr1, 3));

			//Array Clear() -- array to clear, starting index, total elements to clear
			Array.Clear(arr1, 0, 3);
			Console.WriteLine("arr1 contains the following: ");
			foreach(var i in arr1)
				{ 
					Console.WriteLine(i);
				}

			//Array Copy() -- copy from array, copy to array, total elemtns to copy
			var arr2Copy = new int[3];
			Array.Copy(arr2, arr2Copy, 2);
			Console.WriteLine("arr2Copy[1]: " + arr2Copy[1]);

			//Array Sort()
			var arrUnsorted = new int[] { 8, 3, 7, 1, 2, 11 };
			Array.Sort(arrUnsorted);
			Console.WriteLine("arrUnsorted[0] after sort: " + arrUnsorted[0]);

			//Array Reverse()
			Array.Reverse(arrUnsorted);
			Console.WriteLine("arrUnsorted[0] after reverse: " + arrUnsorted[0]);

			//Matrix (rectangular)
			var mat1 = new bool[,] { 
									{ true, false, false },
									{ true, true, false },
									{ true, false, true }
								  };
			Console.WriteLine("mat1[1, 2]: " + mat1[1, 2]);

			//Matrix (jagged 'array of arrays')
			var mat2 = new char[][] {
									new char[] { 'a' },
									new char[] { 'b', 'c', 'd', 'e', 'f', 'g' },
									new char[] { 'i', 'h' }
								   };
			Console.WriteLine("mat2[1][5]: " + mat2[1][5]);

			///////////Mixed types with 'object'///////////

			//Matrix (rectangular) of different types
			var mat3 = new object[,] {
										{ true, false, true },
										{ "this", "that", "other" },
										{ 7, 8, 9 }
									 };
			Console.WriteLine("mat3[1, 2]: " + mat3[1, 2]);

			//Matrix (jagged) of different types
			var mat4 = new object[][] {
										new object[] { "this", "that" },
										new object[] { false, true, false},
										new object[] { 1, 2, 3, 4, 5}
									  };
			Console.WriteLine("mat4[2][4]: " + mat4[2][4]);

			///////////Objects///////////////////////////////////////////////////////////////////////////////////////////////////

			//Array Object
			Arrays arrObj2 = new Arrays(new int[] { 1, 2, 3 }, new double[] { 4.4, 5.5, 6.6 }, new string[] { "This", "That", "Other" });
			Console.WriteLine("arrObj2.Array1[0]: " + arrObj2.Array1[1]);
			Console.WriteLine("arrObj2.Array1[1]: " + arrObj2.Array1[2]);
			Console.WriteLine("arrObj2.Array1[2]: " + arrObj2.Array1[2]);

			//Array Object
			Arrays arrObj3 = new Arrays(new int[0], new double[0], new string[0]);
			arrObj3.Array1 = new int[] { 11, 22, 33 };
			Console.WriteLine("arrObj3.Array1[0]: " + arrObj3.Array1[0]);

			//Matrix object (rectangular)
			MatrixRectangular matrixSquareObj = new MatrixRectangular(new int[0, 0]);
			matrixSquareObj.Matrix1 = new int[,] { 
													{ 1, 2, 3 },
													{ 4, 5, 6 },
													{ 7, 8, 9 } 
												 };
			Console.WriteLine("matrixSquareObj.Matrix1[2,1]: " + matrixSquareObj.Matrix1[2,1]);

			//Matrix object (jagged 'array of arrays')
			MatrixJagged matrixJaggedObj = new MatrixJagged(new int[0][]);
			matrixJaggedObj.Matrix1 = new int[][] { 
													new[] { 1, 2 },
													new[] { 3 },
													new[] { 4, 5, 6, 7 },
													new[] { 8, 9 } 
												  };
			Console.WriteLine("matrixJaggedObj.Matrix1[1][1]: " + matrixJaggedObj.Matrix1[2][3]);
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

		public class MatrixRectangular
		{
			public MatrixRectangular(int[,] m1)
			{
				matrix1 = m1;
			}

			private int[,] matrix1 = new int[0, 0];

			public int[,] Matrix1
			{
				get { return matrix1; }
				set { matrix1 = value; }
			}
		}

		public class MatrixJagged
		{
			public MatrixJagged(int[][] m1)
			{
				matrix1 = m1;
			}

			private int[][] matrix1 = new int[0][];

			public int[][] Matrix1
			{
				get { return matrix1; }
				set { matrix1 = value; }
			}
		}
	}
}
