using System;
using System.Reflection;

namespace PracticeExamples
{
	public class AccessModifiersExamples
	{
		public static void AccessModifiersExamplesMain()
		{
			Console.WriteLine("\n *********** ACCESS MODIFIERS EXAMPLES *********** \n");

			var person = new Person();

			person.PublicName = "Public Access Name";
			person.SetPrivateAccessName("Private Access Name");
			person.InternalName = "Internal Access Name";

			var inheritedClass = new InheritedClass();
			inheritedClass.SetProtectedAccessName("Protected Access Name");
			inheritedClass.SetProtectedInternalAccessName("Protected Internal Access Name");

			person.SetUnsetAccessName("Unset Access Name");

			///////////

			Console.WriteLine("\nPerson:");
			string[] accessNames = person.GetNames();
			foreach(string name in accessNames)
			{ Console.WriteLine($"Name: {name}"); }

			Console.WriteLine("\nInheritedClass:");
			string[] inheritedNames = inheritedClass.GetNames();
			foreach(string name in inheritedNames)
			{ Console.WriteLine($"Name: {name}"); }
		}

		public class Person
		{
			public string PublicName;							//Public - Accessable from outside of its scope
			private string _privateName;						//Private - Only accessable within the same scope (private fields start with an underscore)
			internal string InternalName;						//Internal - Only accessable 'internally' from within its own assembly ('internal' field in assembly1.cs cannot be accessed by assembly2.cs)
			protected string ProtectedName;						//Protected - Only accessable from within its own class or by inheritance of that class
			protected internal string ProtectedInternalName;    //Protected Internal - Only accessable 'internally' from within its own assembly, and within its own class or by inheritance of that class
			string UnsetAccessName;								//No access modifier - defaults to private

			public void SetPrivateAccessName(string privateName)
			{ _privateName = privateName; }

			public void SetUnsetAccessName(string unsetAccessName)
			{ UnsetAccessName = unsetAccessName; }

			public string[] GetNames()
			{
				var returnString = new string[] { PublicName, _privateName, InternalName, ProtectedName, ProtectedInternalName, UnsetAccessName };
				return returnString;
			}
		}

		//Inherited members are copies and only modified locally, so protected fields within 'Person' cannot be directly modified. 
		public class InheritedClass : Person
		{
			public void SetProtectedAccessName(string protectedName)
			{ ProtectedName = protectedName; }

			public void SetProtectedInternalAccessName(string protectedInternalName)
			{ ProtectedInternalName = protectedInternalName; }

			public string[] GetNames()
			{
				var returnString = new string[] { ProtectedName, ProtectedInternalName };
				return returnString;
			}
		}
	}
}
