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

			var constructorInjection = new ConstructorInjection(new TextPrinter());
			constructorInjection.Print();

			var methodInjection = new MethodInjection();
			methodInjection.Print(new TextPrinter());

			var propertyInjection = new PropertyInjection();
			propertyInjection.Text = new TextPrinter();
			propertyInjection.Print();
		}

		class TextPrinter : IText
		{
			public void Print()
			{ Console.WriteLine("TextPrinter: Print method called."); }
		}

		/// Construtor Dependancy Injection
		public class ConstructorInjection
		{
			private IText _text;
			
			public ConstructorInjection(IText text)
			{ _text = text; }

			public void Print()
			{ _text.Print();}
		}

		/// Method Dependancy Injection
		public class MethodInjection
		{
			public void Print(IText text)
			{ text.Print(); }
		}

		/// Property Dependancy Injection
		public class PropertyInjection
		{
			public IText Text { get; set; }

			public void Print()
			{ Text.Print(); }
		}

		/////////// Interface ///////////

		public interface IText
		{ void Print(); }
	}
}
