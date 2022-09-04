using System;
using System.Collections.Generic;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class LiskovSubstitution
	{
		public static void LiskovSubstitutionMain()
		{
			Console.WriteLine("\n *********** LISKOV SUBSTITUTION PRINCIPAL *********** \n");

			//Square
			var square = new Square(6, 6);
			float squareArea = square.Width * square.Height;
			Console.WriteLine($"{nameof(square)} -- Width: {square.Width}, Height: {square.Height}, Area: {squareArea}");

			//Retangle
			var rectangle = new Rectangle(2, 3);
			float rectangleArea = rectangle.Width * rectangle.Height;
			Console.WriteLine($"{nameof(rectangle)} -- Width: {rectangle.Width}, Height: {rectangle.Height}, Area: {rectangleArea}");
		}

		/// ///////////////////////////////// Liskov Substitution principal /////////////////////////////////
		//- Substituting a base type for a subtype
		//- "If S is a subtype of T then objects of type T may be replaced by object of type S"

		//Base class
		public class Square
		{
			public int Width { get; set; }
			public int Height { get; set; }

			public Square() 
			{ }

			public Square(int width, int height)
			{
				Width = width;
				Height = height;
			}

			public override string ToString()
			{ return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}"; }
		}

		//Derived class -- inherits 'Square'
		public class Rectangle : Square
		{
			public Rectangle(int width, int height)
			{
				Width = width;
				Height = height;
			}

			public override string ToString()
			{ return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}"; }
		}
	}
}
