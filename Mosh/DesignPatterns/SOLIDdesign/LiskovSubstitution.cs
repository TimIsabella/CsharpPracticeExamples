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
			var square = new Square(3, 3, "Red");
			Console.WriteLine($"{nameof(square)} -- Length: {square.Length}, Width: {square.Width}, Area: {square.AreaMethod()}, Color: {square.ColorMethod()}");

			//Retangle
			var rectangle = new Rectangle(3, 6, "Blue");
			Console.WriteLine($"{nameof(rectangle)} -- Length: {rectangle.Length}, Width: {rectangle.Width}, Area: {rectangle.AreaMethod()}, Color: {rectangle.ColorMethod()}");

			//Rhombus
			var rhombus = new Rhombus(6, 9, "Green");
			Console.WriteLine($"{nameof(rhombus)} -- Length: {rhombus.Length}, Width: {rhombus.Width}, Area: {rhombus.AreaMethod()}, Color: {rhombus.ColorMethod()}");
		}

		/// ///////////////////////////////// Liskov Substitution principal /////////////////////////////////
		//- Substituting a base type for a subtype
		//- "If S is a subtype of T then objects of type T may be replaced by objects of type S"
		//- Don't make sub-classes which don't have the same functionality of the super-class if they are expected to be used interchangeably
		//
		//- Example
		//-- 1. We have a parent class
		//-- 2. We then have a class named "world" which calls a child
		//-- 3. Class "world" should be able to swap the child class for the parent class without having the code modified

		//Base class
		public class Shape
		{
			public int Length { get; set; }
			public int Width { get; set; }
			public string Color { get; set; }

			public Shape() 
			{ }

			public int AreaMethod()
			{ return Length * Width; }

			public string ColorMethod()
			{ return $"The color is {Color}"; }
		}

		//Derived class -- inherits 'Shape'
		public class Square : Shape
		{
			public Square(int length, int width, string color)
			{
				Length = length;
				Width = width;
				Color = color;
			}
		}

		//Derived class -- inherits 'Shape'
		public class Rectangle : Shape
		{
			public Rectangle(int length, int width, string color)
			{
				Length = length;
				Width = width;
				Color = color;
			}
		}

		//Derived class -- inherits 'Shape'
		public class Rhombus : Shape
		{
			public Rhombus(int length, int width, string color)
			{
				Length = length;
				Width = width;
				Color = color;
			}
		}
	}
}
