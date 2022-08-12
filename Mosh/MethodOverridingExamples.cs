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

			var draw = new Shape();
			draw.Draw();

			var circle = new Circle();
			circle.Draw();
		}

		public class Shape 
		{ 
			public int Width; 
			public int Height;
			public virtual void Draw()	//'virtual' designation allows derived objects to replace it when inherited
			{ Console.WriteLine("Shape: This is the default 'Draw' method."); } 
		}

		public class Circle : Shape 
		{ 
			public int Radius;
			public override void Draw()  //Replacement of inherited method by using 'override'
			{ Console.WriteLine("Circle: This 'Draw' method has been overridden."); }
		}
		public class Image : Shape 
		{
			public int Resolution;
			public override void Draw()
			{ Console.WriteLine("Image: This 'Draw' method has been overridden"); }
		}
	}
}
