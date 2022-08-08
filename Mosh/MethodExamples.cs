﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class MethodExamples
	{
		public static void MethodExamplesMain()
		{
			Console.WriteLine("\n *********** METHOD MODIFIERS *********** \n");

			//Param
			var paramsResult1 = MethodExamples.ParamsModifer(new int[] { 1, 2, 3 });
			var ParamsResult2 = MethodExamples.ParamsModifer(1, 2, 3);

			//Ref
			var refVariableA = 11;
			Console.WriteLine("refVariableA = " + refVariableA);
			MethodExamples.RefModifier(ref refVariableA);
			Console.WriteLine("refVariableA = " + refVariableA);

			//Out
			var outVariableStr = "abc";
			var outVariableInt = 123;
			Console.WriteLine("outVariable = {0}, outVariableInt = {1}", outVariableStr, outVariableInt);
			MethodExamples.OutModifier(out outVariableStr, out outVariableInt);
			Console.WriteLine("outVariable = {0}, outVariableInt = {1}", outVariableStr, outVariableInt);


		}

		/////////// Overloading methods ///////////
		public void OverloadedMethod(int x, int y) //Two parameters of ints
		{
		}

		public void OverloadedMethod(Point newLocation) //One parameter of 'Point' object
		{
		}

		public void OverloadedMethod(Point newLocation, int speed) //Two parameters: one of 'Point' object and one of int
		{
		}

		/////////// Params modifier -- Allows varying number of parameters ///////////
		public static int[] ParamsModifer(params int[] numbers)
		{
			Console.WriteLine("Params passed in: ");
			foreach(int n in numbers) Console.WriteLine(n);
			return numbers;
		}

		/////////// Ref modifier -- directly changes the variable reference ///////////
		public static void RefModifier(ref int refVariableB)
		{
			refVariableB += 22;
		}

		/////////// Out Modifier -- replaces the argument variable in line with the parameter ///////////
		public static void OutModifier(out string outResultStr, out int outResultInt)
		{
			outResultStr = "xyz";
			outResultInt = 456;
		}
	}

	public class Point
	{
	}
}
