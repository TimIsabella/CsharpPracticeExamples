using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class AbstractExamples
	{
		public static void MethodOverridingExamplesMain()
		{
			Console.WriteLine("\n *********** ABSTRACT *********** \n");
			
			var shapes = new List<ShapeObjects.Shape>(); //List of 'Shape' as objects below all inherit from 'Shape'
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

			public abstract class Shape
			{
				public int Width;
				public int Height;
				public abstract void Draw();  //'abstract' designation allows derived objects to replace this default method when inherited
			}

			public class Circle : Shape
			{
				public int Radius;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Circle: This 'Draw' method has been overridden."); }
			}

			public class Square : Shape
			{
				public int Diameter;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Square: This 'Draw' method has been overridden."); }
			}

			public class Triangle : Shape
			{
				public int Tangent;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Triangle: This 'Draw' method has been overridden."); }
			}
		}
	}
}
