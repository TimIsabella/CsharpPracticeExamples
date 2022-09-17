using System;
using System.Collections.Generic;

namespace PracticeExamples
{
	public class AbstractExamples
	{
		public static void AbstractExamplesMain()
		{
			Console.WriteLine("\n *********** ABSTRACT EXAMPLES *********** \n");
			
			var shapes = new List<ShapeObjects.BaseShape>(); //List of 'Shape' as objects below all inherit from 'Shape'

			shapes.Add(new ShapeObjects.Circle(123.456));
			shapes.Add(new ShapeObjects.Square(234.567));
			shapes.Add(new ShapeObjects.Triangle(345.678));

			foreach(var shape in shapes)
			{ shape.Draw(); }
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
				private int _width;
				private int _height;

				public BaseShape(double num)
				{ }

				//'abstract' designation allows derived objects to replace this default method when inherited
				//Derived objects MUST impliment members marked as 'abstract'
				//All members (except fields) must be marked 'abstract' when declaring 'abstract'
				public abstract void Draw();
				public abstract void OtherMethod();

			}

			public class Circle : BaseShape
			{
				private double _radius;

				//'base()' inherits the the base constructor
				public Circle(double radius) : base(radius)
				{ _radius = radius; }

				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine($"Circle: This abstract 'Draw' method has been overridden. \nThe {nameof(_radius).ToUpperInvariant()} is '{_radius}'"); }

				public override void OtherMethod()
				{ }
			}

			public class Square : BaseShape
			{
				private double _diameter;

				//'base()' inherits the the base constructor
				public Square(double diameter) : base(diameter)
				{ _diameter = diameter; }

				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine($"Circle: This abstract 'Draw' method has been overridden. \nThe {nameof(_diameter).ToUpperInvariant()} is '{_diameter}'"); }

				public override void OtherMethod()
				{ }
			}

			public class Triangle : BaseShape
			{
				private double _tangent;

				//'base()' inherits the the base constructor
				public Triangle(double tangent) : base(tangent)
				{ _tangent = tangent; }

				public override void Draw()  //Replacement of inherited method by using 'override'
				{ Console.WriteLine($"Circle: This abstract 'Draw' method has been overridden. \nThe {nameof(_tangent).ToUpperInvariant()} is '{_tangent}'"); }

				public override void OtherMethod()
				{ }
			}
		}
	}
}
