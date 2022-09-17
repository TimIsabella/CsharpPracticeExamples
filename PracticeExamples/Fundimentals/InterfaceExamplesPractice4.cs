using System;

namespace PracticeExamples
{
	public class InterfaceExamplesPractice4
	{
		public static void InterfaceExamplesPractice4Main()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE 4 *********** \n");

			var extendedClass1 = new ClassExtendedByInterface1(); //Instantiate 'ClassExtendedByInterface1' which is extended by 'Iinterface'
			var extender1 = new ExtensionClass1();                //Instantiate 'ExtensionClass1' which provides the link to the interface
			extender1.ExtensionClassMethod(123, extendedClass1);  //Extend functionality 

			var extendedClass2 = new ClassExtendedByInterface2();
			var extender2 = new ExtensionClass2(456, extendedClass2);
			extender2.ExtensionClassMethod(extendedClass2);
		}

		/////////// Extender Classes ///////////

		//Directly through method
		public class ExtensionClass1
		{
			public void ExtensionClassMethod(int num, Iinterface extend)
			{ extend.Method(num); }
		}

		//Through single constructor
		public class ExtensionClass2
		{
			private int _num;
			private Iinterface _extend;

			public ExtensionClass2(int num, Iinterface extend)
			{
				_num = num;
				_extend = extend;
			}

			public void ExtensionClassMethod(Iinterface _extend)
			{ _extend.Method(_num); }
		}

		/////////// Interface ///////////
		public interface Iinterface
		{ void Method(int num); }

		/////////// Classes Extended by Interface ///////////
		
		public class ClassExtendedByInterface1 : Iinterface
		{
			public void Method(int num)
			{ Console.WriteLine($"ClassExtendedByInterface1: 'Method' called with parameter: {num}"); }
		}

		public class ClassExtendedByInterface2 : Iinterface
		{
			public void Method(int num)
			{ Console.WriteLine($"ClassExtendedByInterface2: 'Method' called with parameter: {num}"); }
		}
	}
}