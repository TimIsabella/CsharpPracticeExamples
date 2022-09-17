using System;

namespace PracticeExamples
{
	public class AccessModifiersExamples
	{
		public static void AccessModifiersExamplesMain()
		{
			Console.WriteLine("\n *********** ACCESS MODIFIERS EXAMPLES *********** \n");

			var person = new EncapsulatedPerson();
			person.PublicName = "Public Name";
			person.SetPrivateName("Private Name");
			person.SetUnsetAccessName("Unset Access Name");

			Console.WriteLine(person.GetNames()[2]);
		}

		public class EncapsulatedPerson
		{
			public string PublicName;							//Public - Accessable from outside of its scope
			private string _privateName;						//Private - Only accessable within the same scope (private fields start with an underscore)
			internal string InternalName;						//Internal - Only accessable 'internally' from within its own class (specifically used for classes)
			protected string ProtectedName;						//Protected - Only accessable from within its own class and by inheritance of that class
			protected internal string ProtectedInternalName;    //Protected Internal - Only accessable 'internally' from within its own class and by inheritance of that class
			string UnsetAccessName;								//No access modifier - defaults to private

			public void SetPrivateName(string privateName)
			{
				_privateName = privateName;
			}

			public void SetUnsetAccessName(string unsetAccessName)
			{
				UnsetAccessName = unsetAccessName;
			}

			public string[] GetNames()
			{
				var returnString = new string[] { PublicName, InternalName, _privateName, UnsetAccessName };
				return returnString;
			}
		}
	}
}
