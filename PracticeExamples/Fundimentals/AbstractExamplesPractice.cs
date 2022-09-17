using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples
{
	public class AbstractExamplesPractice
	{
		public static void AbstractExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** ABSTRACT EXAMPLES PRACTICE *********** \n");
			
			var buttons = new List<BaseButton>();

			buttons.Add(new Up());
			buttons.Add(new Down());
			buttons.Add(new Left());
			buttons.Add(new Right());

			//Loop through each
			foreach(var button in buttons)
			{ button.Direction(); }

			//Access by index
			buttons[0].Direction();
			buttons[1].Direction();
			buttons[2].Direction();
			buttons[3].Direction();

			//Access by index LINQ
			buttons.ElementAt(3).Direction();
			buttons.ElementAt(2).Direction();
			buttons.ElementAt(1).Direction();
			buttons.ElementAt(0).Direction();
		}

		/////////// Base abstract class ///////////
		public abstract class BaseButton
		{
			public abstract void Direction();
			public abstract void ButtonPress(int button);
		}

		/////////// Override classes ///////////
		public class Up : BaseButton
		{
			public override void Direction()
			{ Console.WriteLine("Direction: Up"); }
			public override void ButtonPress(int button)
			{ }
		}
		public class Down : BaseButton
		{
			public override void Direction()
			{ Console.WriteLine("Direction: Down"); }
			public override void ButtonPress(int button)
			{ }
		}
		public class Left : BaseButton
		{
			public override void Direction()
			{ Console.WriteLine("Direction: Left"); }
			public override void ButtonPress(int button)
			{ }
		}
		public class Right : BaseButton
		{
			public override void Direction()
			{ Console.WriteLine("Direction: Right"); }
			public override void ButtonPress(int button)
			{ }
		}
	}
}
