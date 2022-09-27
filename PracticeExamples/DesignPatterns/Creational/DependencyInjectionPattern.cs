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
			constructorInjection.Print("constructor");

			//By Method
			var methodInjection = new MethodInjection();
			methodInjection.Print(new TextPrinter(), "method");

			//By Property
			var propertyInjection = new PropertyInjection();
			propertyInjection.Text = new TextPrinter();
			propertyInjection.Print("property");
		}

		class TextPrinter : IText
		{
			public void Print(string injectionType)
			{ Console.WriteLine($"TextPrinter: Print method called by {injectionType}."); }
		}

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

		/////////// Interface ///////////

		public interface IText
		{ void Print(string injectionType); }
	}
}
