using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
	public class ConstructorExample
	{
		//Fields
		public int Id;
		public string FieldName;

		public ConstructorExample()
		{
		}

		public ConstructorExample(int id)
		{
			this.Id = id;
		}

		//Constructor
		public ConstructorExample(int id, string constructorParamName)
		{
			this.FieldName = constructorParamName;
			this.Id = id;
		}
	}
}
