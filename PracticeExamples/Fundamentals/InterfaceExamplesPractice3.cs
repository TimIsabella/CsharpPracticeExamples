using System;

namespace PracticeExamples
{
	public class InterfaceExamplesPractice3
	{
		public static void InterfaceExamplesPractice3Main()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE 3 *********** \n");

			var extender1 = new Extender(123, "one two three");
			var extendedClass1 = new ClassExtendedByInterface1();
			extender1.ExtenderMethod1(extendedClass1);
			extender1.ExtenderMethod2(extendedClass1);
			extender1.ExtenderMethod3(extendedClass1);

			var extender2 = new Extender(456, "four five six", 1.618f);
			var extendedClass2 = new ClassExtendedByInterface2();
			extender2.ExtenderMethod4(extendedClass2);
			extender2.ExtenderMethod5(extendedClass2);
			extender2.ExtenderMethod6(extendedClass2);

			var extender3 = new Extender(789, "seven eight, nine", 3.14f);
			var extendedClass3 = new ClassExtendedByInterface3();
			extender3.ExtenderMethod1to3(extendedClass3);
			extender3.ExtenderMethod4to6(extendedClass3);
		}

		public class Extender
		{
			private int _num;
			private string _str;
			private float _flo;

			public Extender(int num, string str)
			{
				_num = num;
				_str = str;
			}

			public Extender(int num, string str, float flo)
			{
				_num = num;
				_str = str;
				_flo = flo;
			}

			public void ExtenderMethod1(Iinterfaces.Iinterface1 extend)
			{ extend.Method1(); }

			public void ExtenderMethod2(Iinterfaces.Iinterface2 extend)
			{ extend.Method2(_num); }

			public void ExtenderMethod3(Iinterfaces.Iinterface3 extend)
			{ extend.Method3(_str); }

			public void ExtenderMethod4(Iinterfaces.Iinterface4 extend)
			{ extend.Method4(_num * 2); }

			public void ExtenderMethod5(Iinterfaces.Iinterface5 extend)
			{ extend.Method5(_str + " --- #2"); }

			public void ExtenderMethod6(Iinterfaces.Iinterface6 extend)
			{ extend.Method6(_flo); }

			public void ExtenderMethod1to3(Iinterfaces.Iinterface1to3 extend)
			{
				extend.Method1();
				extend.Method2(_num);
				extend.Method3(_str);
			}

			public void ExtenderMethod4to6(Iinterfaces.Iinterface4to6 extend)
			{
				extend.Method4(_num * 2);
				extend.Method5(_str + " #2");
				extend.Method6(_flo);
			}
		}

		/////////// Interfaces ///////////

		public interface Iinterfaces
		{
			public interface Iinterface1
			{ void Method1(); }

			public interface Iinterface2
			{ void Method2(int num); }

			public interface Iinterface3
			{ void Method3(string str); }

			public interface Iinterface4
			{ void Method4(int num); }

			public interface Iinterface5
			{ void Method5(string str); }

			public interface Iinterface6
			{ void Method6(float flo); }

			public interface Iinterface1to3
			{
				void Method1();
				void Method2(int num);
				void Method3(string str);
			}

			public interface Iinterface4to6
			{
				void Method4(int num);
				void Method5(string str);
				void Method6(float flo);
			}
		}

		/////////// Classes Extended by Interface ///////////

		public class ClassExtendedByInterface1 : Iinterfaces.Iinterface1, Iinterfaces.Iinterface2, Iinterfaces.Iinterface3
		{
			public void Method1()
			{ Console.WriteLine("#1 Message from Method1"); }

			public void Method2(int num)
			{ Console.WriteLine($"#1 Message from Method2 with num: {num}"); }

			public void Method3(string str)
			{ Console.WriteLine($"#1 Message from Method3 with str: {str}"); }
		}

		public class ClassExtendedByInterface2 : Iinterfaces.Iinterface4, Iinterfaces.Iinterface5, Iinterfaces.Iinterface6
		{
			public void Method4(int num)
			{ Console.WriteLine($"#2 Message from Method4 with num: {num}"); }

			public void Method5(string str)
			{ Console.WriteLine($"#2 Message from Method5 with str: {str}"); }

			public void Method6(float flo)
			{ Console.WriteLine($"#2 Message from Method3 with float: {flo}"); }
		}

		public class ClassExtendedByInterface3 : Iinterfaces.Iinterface1to3, Iinterfaces.Iinterface4to6
		{
			public void Method1()
			{ Console.WriteLine("#3 Message from Method1"); }

			public void Method2(int num)
			{ Console.WriteLine($"#3 Message from Method2 with num: {num}"); }

			public void Method3(string str)
			{ Console.WriteLine($"#3 Message from Method3 with str: {str}"); }

			public void Method4(int num)
			{ Console.WriteLine($"#3 Message from Method4 with num: {num}"); }

			public void Method5(string str)
			{ Console.WriteLine($"#3 Message from Method5 with str: {str}"); }

			public void Method6(float flo)
			{ Console.WriteLine($"#3 Message from Method6 with float: {flo}"); }
		}
	}
}