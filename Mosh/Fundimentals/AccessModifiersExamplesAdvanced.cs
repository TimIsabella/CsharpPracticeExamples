using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class AccessModifiersExamplesAdvanced
	{
		public static void AccessModifiersExamplesAdvancedMain()
		{
			Console.WriteLine("\n *********** ACCESS MODIFIERS *********** \n");

			var publicAccess = new PublicClass(); publicAccess.PublicClassMethod();
			//var privateClass = new RestrictedAccessModifierClasses.PrivateClass();		//Cannot access private class from outside
			var internalClass = new InternalClass(); internalClass.InternalClassMethod();

			var protectedClass = new RestrictedAccessModifierClasses(); protectedClass.ProtectedClassOuterMethod();

			var protectedInternalClass = new ProtectedInternalAccess();
			protectedInternalClass.ProtectedInternalClassMethod();
		}

		public class ProtectedAccess : RestrictedAccessModifierClasses
		{ }

		internal class ProtectedInternalAccess : RestrictedAccessModifierClasses.ProtectedInternalClass
		{ }
	}

	public class PublicClass //Public - Accessable from outside of its scope
	{
		public void PublicClassMethod() { Console.WriteLine("Public Class Accessed"); }
	}

	internal class InternalClass //Internal - Only accessable 'internally' from within its own class (specifically used for classes)
	{
		public void InternalClassMethod() { Console.WriteLine("Internal Class Accessed"); }
	}

	class UnsetClass //No access modifier - defaults to internal
	{
		public void UnsetClassMethod() { Console.WriteLine("Unset Class Accessed"); }
	}

	//Below classes cannot be placed in namespace and must be contained within a parent class
	public class RestrictedAccessModifierClasses
	{
		///////////
		private class PrivateClass //Private - Only accessable within the same scope (private fields start with an underscore)
		{
			public void PrivateClassMethod() { Console.WriteLine("Private Class Accessed"); }
		}

		///////////
		protected class ProtectedClass //Protected - Only accessable from within its own class and by inheritance of that class
		{
			public void ProtectedClassMethod() { Console.WriteLine("Protected Class Accessed"); }
		}
		public void ProtectedClassOuterMethod() { var pc = new ProtectedClass(); pc.ProtectedClassMethod(); }

		///////////
		protected internal class ProtectedInternalClass //Protected Internal - Only accessable 'internally' from within its own class and by inheritance of that class
		{
			public void ProtectedInternalClassMethod() { Console.WriteLine("Protected Internal Class Accessed"); }
		}
	}
}
