using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class InterfaceSegregation
	{
		public static void InterfaceSegregationMain()
		{
			Console.WriteLine("\n *********** INTERFACE SEGREGATION PRINCIPAL *********** \n");
			///- Break up interfaces into smaller parts as necessary
			
		}

		public class Document
		{ }

		/////////// Interfaces ///////////
		
		/// NOT segreated and cannot be used for different machines
		public interface IMachine
		{
			void Print(Document doc);
			void Scan(Document doc);
			void Fax(Document doc);
			void MultiFunction(Document doc);
		}

		/// Segregated interfaces which can be used for many machine
		public interface IPrint
		{ void Print(Document doc); }

		public interface IScan
		{ void Scan(Document doc); }

		public interface IFax
		{ void Fax(Document doc); }

		public interface IMultiFunctionDevice : IPrint, IScan, IFax //Inherits all above and includes an additional method
		{ public void MultiFunction(Document doc); }

		/////////// 

		public class OldPrinter : IPrint
		{
			public void Print(Document doc)
			{ }
		}

		public class FaxMachine : IFax, IScan
		{
			public void Fax(Document doc)
			{ }
			public void Scan(Document doc)
			{ }
		}

		public class MultiFunctionPrinter : IPrint, IScan, IFax
		{
			public void Print(Document doc)
			{ }
			public void Scan(Document doc)
			{ }
			public void Fax(Document doc)
			{ }
		}

		public class MultiFunctionAppliance : IMultiFunctionDevice
		{
			public void Print(Document doc)
			{ }
			public void Scan(Document doc)
			{ }
			public void Fax(Document doc)
			{ }
			public void MultiFunction(Document doc)
			{ }
		}

		//Delgating interfaces by 'decoator pattern'
		public class SuperFunctionAppliance : IMultiFunctionDevice
		{
			private IPrint _printer;
			private IScan _scanner;
			private IFax _faxer;
			private IMultiFunctionDevice _multiFunctioner;

			public SuperFunctionAppliance(IPrint print, IScan scan, IFax fax, IMultiFunctionDevice multiFunction)
			{
				_printer = print;
				_scanner = scan;
				_faxer = fax;
				_multiFunctioner = multiFunction;
			}

			//Decorators
			public void Print(Document doc)
			{ _printer.Print(doc); }

			public void Scan(Document doc)
			{ _scanner.Scan(doc); }

			public void Fax(Document doc)
			{ _faxer.Fax(doc); }

			public void MultiFunction(Document doc)
			{ _multiFunctioner.MultiFunction(doc); }
		}
	}
}