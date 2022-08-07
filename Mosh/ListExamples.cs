using System;
using System.Collections.Generic;

namespace Mosh
{
	public class ListExamples
	{
		public static void ListsMain()
		{
			Console.WriteLine("\n *********** LISTS *********** \n");

			//List instantiated as a list of ints and filled with ints
			var listOfInts = new List<int>() { 1, 2, 3 };

			//List instantiated as an array of objects and filled with object arrays of multiple types
			var listOfArrays = new List<object[]>() { 
												    new object[] { 1, 2, 3 },
													new object[] { true , false },
													new object[] { "this" , "that", "those" },
												   };

			///////////List instance memebers: accessable for objects///////////
			
			Console.WriteLine("listOfInts count: " + listOfInts.Count);

			///////////List static methods: accessable by class///////////

			//Add() -- adds to the end of list
			listOfInts.Add(5);
			Console.WriteLine("listOfInts[2]: " + listOfInts[2]);

			//Contains()
			Console.WriteLine("listOfInts Contains '5': " + listOfInts.Contains(5));

			//IndexOf()
			Console.WriteLine("listOfInts IndexOf '5': " + listOfInts.IndexOf(5));

			//Remove()
			listOfInts.Remove(5); //Removes '5' from list

			//AddRange() -- adds range to end of list
			listOfInts.AddRange(new int[] { 1, 2, 3 });

			Console.WriteLine("Range added to listOfInts...");
			foreach(var i in listOfInts)
			{
				Console.WriteLine(i);
			}

			//Clear() -- clears entire list
			listOfInts.Clear();
		}
	}
}
