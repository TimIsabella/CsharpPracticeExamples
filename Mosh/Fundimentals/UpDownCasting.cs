using System;

namespace PracticeExamples
{
	public class UpDownCasting
	{
		public static void UpDownCastingMain()
		{
			Console.WriteLine("\n *********** UP/DOWN CASTING *********** \n");

			var circle = new Circle();
			var shape = new Shape();

			///////////UPCASTING - Conversion from derived class to base class///////////
			Shape shapeUp = circle;		//Explicit cast (will throw exceptions if not possible)
			shapeUp.Width = 111;
			shapeUp.Height = 222;

			//Casting with 'as'
			var shapeUp2 = circle as Shape;     //Does not throw exception -- returns 'null' if unable to cast
			if(shapeUp2 is Shape)               //Check with 'is'
			{
				Console.WriteLine("Can convert... \n ({0}), ({1})", shapeUp2.Width, shapeUp2.Height);
				shapeUp2.Width = 111;
				shapeUp.Height = 222;
			}

			else Console.WriteLine("Cannot convert");

			///////////DOWNCASTING - Conversion from base class to derived class///////////
			Circle circleDown = (Circle) shapeUp;     //Explicit cast (will throw exceptions if not possible)
			circleDown.Width = 123;
			circleDown.Height = 456;
			circleDown.Radius = 333;

			//Casting with 'as'
			var circleDown2 = shapeUp as Circle;	//Does not throw exception -- returns 'null' if unable to cast
			if(circleDown2 is Circle)				//Check with 'is'
			  {
				circleDown2.Width = 123;
				circleDown2.Height = 456;
				circleDown2.Radius = 789;
				Console.WriteLine("Can convert... \n ({0}), ({1}), ({2})", circleDown2.Width, circleDown2.Height, circleDown2.Radius);
			}
				
			else Console.WriteLine("Cannot convert");
			
		}

		public class Shape { public int Width; public int Height; }
		public class Circle : Shape { public int Radius; }
	}
}