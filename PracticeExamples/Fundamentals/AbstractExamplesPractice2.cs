using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeExamples
{
	public class AbstractExamplesPractice2
	{
		public static void AbstractExamplesPractice2Main()
		{
			Console.WriteLine("\n *********** ABSTRACT EXAMPLES PRACTICE 2 *********** \n");

			var animals = new List<BaseAnimal>();

			animals.Add(new Cat());
			animals.Add(new Dog());
			animals.Add(new Mouse());

			animals[0].Speak();
			animals[1].Speak();
			animals[2].Speak();
		}

		/////////// Base abstract class ///////////
		public abstract class BaseAnimal
		{
			public abstract void Eyes();
			public abstract void Mouth();
			public abstract void Speak();
		}

		/////////// Override classes ///////////
		public class Cat : BaseAnimal
		{
			public override void Eyes()
			{}
			public override void Mouth()
			{ }
			public override void Speak()
			{ Console.WriteLine("Meow!"); }
		}

		public class Dog : BaseAnimal
		{
			public override void Eyes()
			{ }
			public override void Mouth()
			{ }
			public override void Speak()
			{ Console.WriteLine("Bark!"); }
		}

		public class Mouse : BaseAnimal
		{
			public override void Eyes()
			{ }
			public override void Mouth()
			{ }
			public override void Speak()
			{ Console.WriteLine("Squeek!"); }
		}
	}
}
