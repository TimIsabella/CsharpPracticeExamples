using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
	public class DependencyInjectionPattern
	{
		public static void DependencyInjectionPatternMain()
		{
			Console.WriteLine("\n *********** DEPENDENCY INJECTION EXAMPLES *********** \n");

			//By Constructor
			var constructorInjection = new ConstructorInjection(new TextPrinter());
			constructorInjection.Print("Dependency injection by constructor");

			//By Method
			var methodInjection = new MethodInjection();
			methodInjection.Print(new TextPrinter(), "Dependency injection by method");

			//By Property
			var propertyInjection = new PropertyInjection();
			propertyInjection.Text = new TextPrinter();
			propertyInjection.Print("Dependency injection by property");

			//By Property
			var fieldInjection = new FieldInjection();
			fieldInjection.Text = new TextPrinter();
			fieldInjection.Print("Dependency injection by field");
		}

		//////////////////////////////////////////////////////////////////
		///The below makes the connection between passed in class and matching interface 
		///- The connection of matching the interface and class method signature is called "Late Binding" or "Dynamic Dispatch"
		///- This dynamic connection is established at runtime and is a type of polymorphism

		/// Construtor Dependancy Injection
		public class ConstructorInjection
		{
			private IText _text;
			
			public ConstructorInjection(IText text)
			{ _text = text; }

			public void Print(string injectionType)
			{ _text.Print(injectionType);}
		}

		/// Method Dependancy Injection
		public class MethodInjection
		{
			public void Print(IText text, string injectionType)
			{ text.Print(injectionType); }
		}

		/// Property Dependancy Injection
		public class PropertyInjection
		{
			public IText Text { get; set; }

			public void Print(string injectionType)
			{ Text.Print(injectionType); }
		}

		/// Field Dependancy Injection
		public class FieldInjection
		{
			public IText Text;

			public void Print(string injectionType)
			{ Text.Print(injectionType); }
		}

		/////////////////////////////////

		///Interface
		public interface IText
		{ void Print(string injectionType); }

		///Class Extended by Interface
		class TextPrinter : IText
		{
			public void Print(string injectionType)
			{ Console.WriteLine($"TextPrinter: Print method called by {injectionType}."); }
		}
	}
}
