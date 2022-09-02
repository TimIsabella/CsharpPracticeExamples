using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class MethodOverridingExamples
	{
		public static void MethodOverridingExamplesMain()
		{
			//Method overriding - modifying an implementation of an inherited method
			Console.WriteLine("\n *********** METHOD OVERRIDING *********** \n");

			//var draw = new Shapes.BaseShape(); draw.Draw();
			//var circle = new Shapes.Circle(); circle.Draw();
			//var square = new Shapes.Circle(); square.Draw();
			//var triangle = new Shapes.Circle(); triangle.Draw();
			//var image = new Image(); image.Draw();

			var shapes = new List<ShapeObjects.BaseShape>(); //List of 'BaseShape' as objects below all inherit from 'BaseShape'
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
			public class BaseShape
			{
				public int Width;
				public int Height;
				public virtual void Draw()  //'virtual' designation allows derived objects to replace this default method when inherited
				{ Console.WriteLine("BaseShape: This is the default 'Draw' method."); }
			}

			public class Circle : BaseShape
			{
				public int Radius;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Circle: This 'Draw' method has been overridden."); }
			}

			public class Square : BaseShape
			{
				public int Diameter;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Square: This 'Draw' method has been overridden."); }
			}

			public class Triangle : BaseShape
			{
				public int Tangent;
				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine("Triangle: This 'Draw' method has been overridden."); }
			}

			//No method override
			public class Image : BaseShape
			{
				public int Resolution;

				//No method override, so default method inherited from 'BaseShape' will be used
				//public override void Draw()
				//{ Console.WriteLine("Image: This 'Draw' method has been overridden"); }
			}
		}
	}
}
