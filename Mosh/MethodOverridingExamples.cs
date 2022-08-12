using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class MethodOverridingExamples
	{
		public static void MethodOverridingExamplesMain()
		{
			//Method overriding - modifying an implementation of an inherited method
			Console.WriteLine("\n *********** METHOD OVERRIDING *********** \n");

			//var draw = new Shapes.Shape(); draw.Draw();
			//var circle = new Shapes.Circle(); circle.Draw();
			//var square = new Shapes.Circle(); square.Draw();
			//var triangle = new Shapes.Circle(); triangle.Draw();
			//var image = new Image(); image.Draw();

			var shapes = new List<ShapeObjects.Shape>(); //List of 'Shape' as objects below all inherit from 'Shape'
			shapes.Add(new ShapeObjects.Circle());
			shapes.Add(new ShapeObjects.Square());
			shapes.Add(new ShapeObjects.Triangle());

			foreach(var shape in shapes)
			{
				shape.Draw();
			}
		}
	}

	//All Shapes
	public class ShapeObjects
	{
		//Base shape object
		public class Shape
		{
			public int Width;
			public int Height;
			public virtual void Draw()  //'virtual' designation allows derived objects to replace this default method when inherited
			{ Console.WriteLine("Shape: This is the default 'Draw' method."); }
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

		//No method override
		public class Image : Shape
		{
			public int Resolution;

			//No method override, so default method inherited from 'Shape' will be used
			//public override void Draw()
			//{ Console.WriteLine("Image: This 'Draw' method has been overridden"); }
		}
	}
}
