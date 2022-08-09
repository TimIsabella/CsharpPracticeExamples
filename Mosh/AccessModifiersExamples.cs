using System;

namespace Mosh
{
	public class AccessModifiersExamples
	{
		public static void AccessModifiersExamplesMain()
		{
			var person = new EncapsulatedPerson();
			person.PublicName = "Public Name";
			person.SetPrivateName("Private Name");
			person.SetInternalName("Internal Name");

			Console.WriteLine(person.GetNames()[1]);
		}

		public class EncapsulatedPerson
		{
			public string PublicName;
			internal string InternalName;
			private string _privateName;  //private fields start with an underscore

			public void SetPrivateName(string privateName)
			{
				_privateName = privateName;
			}

			public void SetInternalName(string internalName)
			{
				InternalName = internalName;
			}

			public string[] GetNames()
			{
				var returnString = new string[] { PublicName, _privateName, InternalName };
				return returnString;
			}
		}
	}
}
