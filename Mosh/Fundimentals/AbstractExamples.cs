﻿using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class AbstractExamples
	{
		public static void AbstractExamplesMain()
		{
			Console.WriteLine("\n *********** ABSTRACT *********** \n");
			
			var shapes = new List<ShapeObjects.BaseShape>(); //List of 'Shape' as objects below all inherit from 'Shape'
			shapes.Add(new ShapeObjects.Circle());
			shapes.Add(new ShapeObjects.Square());
			shapes.Add(new ShapeObjects.Triangle());

			foreach(var shape in shapes)
			{
				shape.Draw();
			}
		}

		//All Shapes
		public class ShapeObjects
		{
			//Base shape object
			//The class must be declared as 'abstract' if it impliments abstract members
			//'abstract' classes CANNOT be instantiated
			public abstract class BaseShape
			{
				//Fields do not have to be marked abstract
				public int Width;
				public int Height;

				//'abstract' designation allows derived objects to replace this default method when inherited
				//Derived objects MUST impliment members marked as 'abstract'
				//All members (except fields) must be marked 'abstract' when declaring 'abstract'
				public abstract void Draw();
				public abstract void OtherMethod();

			}

			public class Circle : BaseShape
			{
				public int Radius;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Circle: This abstract 'Draw' method has been overridden."); }
				public override void OtherMethod()
				{ }
			}

			public class Square : BaseShape
			{
				public int Diameter;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Square: This abstract 'Draw' method has been overridden."); }
				public override void OtherMethod()
				{ }
			}

			public class Triangle : BaseShape
			{
				public int Tangent;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Triangle: This abstract 'Draw' method has been overridden."); }
				public override void OtherMethod()
				{ }
			}
		}
	}
}
