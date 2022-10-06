using System;

namespace PracticeExamples
{
	public class InterfaceExamplesPractice5
	{
		public static void InterfaceExamplesPractice5Main()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE 5 *********** \n");

			///Dependency Injection by constructor
			//Instantiate 'ClassExtendedByInterface' class object which is extended by 'Iinterface'
			var extendedClass1 = new ClassExtendedByInterface1();

			//Instantiate 'ExtensionClass' as 'extender'
			//- Pass in 'extendedClass' which is extended by 'Iinterface'
			//- Constructor takes in the extended class as an 'Iinterface' type
			var extender1 = new ExtensionClass(extendedClass1);

			//Call 'ExtensionClassMethod()' which calls method matching 'Iinterface' signature
			//- Integer is passed to the extended class method
			extender1.ExtensionClassMethod(123);

			///Dependency Injection by method
			var extender2 = new ExtensionClass(new ClassExtendedByInterface2());
			extender2.ExtensionClassMethod(456);

			/////////// Static ///////////

			///Dependency Injection by static method
			ExtensionMethod(new ClassExtendedByInterface3(), 789);

			///Dependency Injection by static property
			ExtensionProperty = new ClassExtendedByInterface4();
			ExtensionProperty.InterfaceMethod(101112);

		}

		/////////// Extender Classes ///////////
		public class ExtensionClass
		{
			private Iinterface _iExtend;

			public ExtensionClass(Iinterface iExtend) //'ClassExtendedByInterface' class object passed in as 'Iinterface' type
			{ _iExtend = iExtend; }

			public void ExtensionClassMethod(int num)
			{ _iExtend.InterfaceMethod(num); }        //Call method on 'ClassExtendedByInterface' matching 'Iinterface' signature

			///The above connection to the matching method signature of the extended class to the interface is called "Late Binding" or "Dynamic Dispatch"
			///- This dynamic connection is established at runtime and is a type of polymorphism
		}

		//Extender Method
		//- Same as above but separated into a static method
		public static void ExtensionMethod(Iinterface iExtend, int num)
		{ iExtend.InterfaceMethod(num); }

		//Extender Property
		//- Same as above but separated into a static property
		public static Iinterface ExtensionProperty { get; set; }

		/// ///////////////////////////////////////////////////////////////////////////////////////////////////

		/////////// Interface ///////////
		public interface Iinterface
		{ void InterfaceMethod(int num); }
		
		/////////// Classes Extended by Interface ///////////
		public class ClassExtendedByInterface1 : Iinterface
		{
			public void InterfaceMethod(int num)
			{ Console.WriteLine($"ClassExtendedByInterface1 -- InterfaceMethod: {num}"); }
		}

		public class ClassExtendedByInterface2 : Iinterface
		{
			public void InterfaceMethod(int num)
			{ Console.WriteLine($"ClassExtendedByInterface2 -- InterfaceMethod: {num}"); }
		}

		public class ClassExtendedByInterface3 : Iinterface
		{
			public void InterfaceMethod(int num)
			{ Console.WriteLine($"ClassExtendedByInterface3 -- InterfaceMethod: {num}"); }
		}

		public class ClassExtendedByInterface4 : Iinterface
		{
			public void InterfaceMethod(int num)
			{ Console.WriteLine($"ClassExtendedByInterface4 -- InterfaceMethod: {num}"); }
		}
	}
}