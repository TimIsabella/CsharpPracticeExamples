using System;

namespace PracticeExamples
{
	public class InterfaceExamplesPractice2
	{
		public static void InterfaceExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE 2 *********** \n");

			var extender1 = new Extender(123, "one two three");
			extender1.ExtenderMethod1(new ClassExtendedByInterface1());

			var extender2 = new Extender(456, "four five six", 1.618f);
			extender2.ExtenderMethod2(new ClassExtendedByInterface2());

			var extender3 = new Extender(789, "seven eight, nine", 3.14f);
			extender3.ExtenderMethod1(new ClassExtendedByInterface3());
			extender3.ExtenderMethod2(new ClassExtendedByInterface3());
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

			public void ExtenderMethod1(Iinterface1 extend)
			{
				Console.WriteLine("Interface1...");
				extend.Method1();
				extend.Method2(_num);
				extend.Method3(_str);
				Console.WriteLine();
			}

			public void ExtenderMethod2(Iinterface2 extend)
			{
				Console.WriteLine("Interface2...");
				extend.Method4(_num * 2);
				extend.Method5(_str + " #2");
				extend.Method6(_flo);
				Console.WriteLine();
			}
		}

		/////////// Interfaces ///////////
		
		public interface Iinterface1
		{
			void Method1();
			void Method2(int num);
			void Method3(string str);
		}

		public interface Iinterface2
		{
			void Method4(int num);
			void Method5(string str);
			void Method6(float flo);
		}

		/////////// Classes Extended by Interface ///////////

		public class ClassExtendedByInterface1 : Iinterface1
		{
			public void Method1()
			{ Console.WriteLine("#1 Message from Method1"); }

			public void Method2(int num)
			{ Console.WriteLine($"#1 Message from Method2 with num: {num}"); }

			public void Method3(string str)
			{ Console.WriteLine($"#1 Message from Method3 with str: {str}"); }
		}

		public class ClassExtendedByInterface2 : Iinterface2
		{
			public void Method4(int num)
			{ Console.WriteLine($"#2 Message from Method4 with num: {num}"); }

			public void Method5(string str)
			{ Console.WriteLine($"#2 Message from Method5 with str: {str}"); }

			public void Method6(float flo)
			{ Console.WriteLine($"#2 Message from Method3 with float: {flo}"); }
		}

		public class ClassExtendedByInterface3 : Iinterface1, Iinterface2
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