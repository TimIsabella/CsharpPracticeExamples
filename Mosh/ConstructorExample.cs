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
		public string FieldName;	

		//Constructor
		public ConstructorExample(string constructorParamName)
		{
			this.FieldName = constructorParamName;
		}
	}
}
