using System;

namespace PracticeExamples
{
	public class InterfaceExamplesPractice
	{
		public static void InterfaceExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** INTERFACE EXAMPLES PRACTICE *********** \n");

			var class1 = new ClassForInterface1();
			var class2 = new ClassForInterface2();
			var class3 = new ClassForInterface3();

			TestInterface1(class1);				//Passing in class1 containing interface2
			TestInterface2(class1, class2);     //Passing in class1 and class2 containing interface1 and interface2 respectivally
			TestInterface3(class3);
		}

		/////////// Methods passed in from class which impliments the interface ///////////
		public static void TestInterface1(Iinterface1 interface1)
		{
			interface1.Method1();
			interface1.Method3("This is a string");
		}

		public static void TestInterface2(Iinterface1 interface1, Iinterface2 interface2)
		{
			interface1.Method2(123);
			interface2.Method5(456);
			interface2.Method4();
			interface1.Method1();
			interface1.Method3("This is a string");
		}
		public static void TestInterface3(ClassForInterface3 class3) //Call the class directly
		{
			class3.Method2(123);
			class3.Method5(456);
			class3.Method4();
			class3.Method1();
		}

		/////////// Interface ///////////
		public interface Iinterface1
		{
			//Contract of methods for interface to expose for public use
			void Method1();
			void Method2(int num);
			void Method3(string str);
		}

		public interface Iinterface2
		{
			//Contract of methods for interface to expose for public use
			Square Method4();
			Circle Method5(int num);
			Triangle Method6(string str);
		}

		/////////// Implement interface ///////////
		public class ClassForInterface1 : Iinterface1
		{
			public void Method1()
			{ Console.WriteLine("Class1-Method1: firing..."); }
			public void Method2(int num1)
			{ Console.WriteLine("Class1-Method2: firing..."); }
			public void Method3(string string1)
			{ Console.WriteLine("Class1-Method3: firing..."); }
		}

		/////////// Implement multiple interfaces ///////////
		public class ClassForInterface2 : Iinterface2
		{
			public Square Method4()
			{ Console.WriteLine("Class2-Method4: firing..."); return new Square(); }
			public Circle Method5(int num2)
			{ Console.WriteLine("Class2-Method5: firing..."); return new Circle(); }
			public Triangle Method6(string string2)
			{ Console.WriteLine("Class2-Method6: firing..."); return new Triangle(); }
		}

		/////////// Implement multiple interfaces ///////////
		public class ClassForInterface3 : Iinterface1, Iinterface2
		{
			public void Method1()
			{ Console.WriteLine("Class3-Method1: firing..."); }
			public void Method2(int num1)
			{ Console.WriteLine("Class3-Method2: firing..."); }
			public void Method3(string string1)
			{ Console.WriteLine("Class3-Method3: firing..."); }
			public Square Method4()
			{ Console.WriteLine("Class3-Method4: firing..."); return new Square(); }
			public Circle Method5(int num2)
			{ Console.WriteLine("Class3-Method5: firing..."); return new Circle(); }
			public Triangle Method6(string string2)
			{ Console.WriteLine("Class3-Method6: firing..."); return new Triangle(); }
		}

		public class Square
		{ }
		public class Circle
		{ }
		public class Triangle
		{ }
	}
}