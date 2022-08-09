using System;

namespace Mosh
{
	public class AccessModifiersExamples
	{
		public static void AccessModifiersExamplesMain()
		{
			var person = new EncapsulatedPerson();
			person.PublicName = "Public Name";
			person.InternalName = "Internal Name";
			person.SetPrivateName("Private Name");
			person.SetUnsetAccessName("Unset Access Name");

			Console.WriteLine(person.GetNames()[2]);
		}

		public class EncapsulatedPerson
		{
			public string PublicName;
			internal string InternalName;
			private string _privateName;  //private fields start with an underscore
			string UnsetAccessName;

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
