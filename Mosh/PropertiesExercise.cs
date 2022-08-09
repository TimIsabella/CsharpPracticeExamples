using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class PropertiesExercise
	{
		public static void PropertiesExerciseMain()
		{
			var person = new EncapsulatedPerson();
			person.PrivateNameProperty = "Private Name Property";
			person.UnsetAccessNameProperty = "Unset Access Name";
			person.PublicName = "Public Name";
			person.InternalName = "Internal Name";
		}

		public class EncapsulatedPerson
		{
			//Fields and separate properties
			//Ppropertis must be separated since fields and private and unset
			private string _privateName;
			string UnsetAccessName;

			public string PrivateNameProperty
			{
				get { return _privateName; }
				set { _privateName = value; }
			}

			public string UnsetAccessNameProperty
			{
				get { return UnsetAccessName; }
				set { UnsetAccessName = value; }
			}

			//Fields with auto-implemented properties
			//Properties can be auto-implimented since fields are accessable (public and internal)
			public string PublicName { get; set; }
			internal string InternalName { get; set; }

			///////////

			public string[] GetNames()
			{
				var returnString = new string[] { PublicName, InternalName, _privateName, UnsetAccessName };
				return returnString;
			}
		}
	}
}
