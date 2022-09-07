﻿using System;

namespace PracticeExamples
{
	public class Composite
	{
		public static void InterfaceExamplesPractice4Main()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE4 *********** \n");

			var extendedClass1 = new ClassExtendedByInterface1();
			var extender1 = new ExtensionClass1();
			extender1.ExtensionClassMethod(123, extendedClass1);

			var extendedClass2 = new ClassExtendedByInterface2();
			var extender2 = new ExtensionClass2(456, extendedClass2);
			extender2.ExtensionClassMethod(extendedClass2);
		}

		//Simple
		public class ExtensionClass1
		{
			public void ExtensionClassMethod(int num, Iinterface extend)
			{ extend.Method(num); }
		}

		//Single constructor
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

		//Interface
		public interface Iinterface
		{ void Method(int num); }

		//Class Extended by Interface
		public class ClassExtendedByInterface1 : Iinterface
		{
			public void Method(int num)
			{ Console.WriteLine($"ClassExtendedByInterface1: 'Method' called with parameter: {num}"); }
		}

		//Class Extended by Interface
		public class ClassExtendedByInterface2 : Iinterface
		{
			public void Method(int num)
			{ Console.WriteLine($"ClassExtendedByInterface2: 'Method' called with parameter: {num}"); }
		}
	}
}