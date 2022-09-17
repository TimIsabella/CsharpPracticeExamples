using System;

namespace PracticeExamples
{
	public class CompositionExamplesPractice
	{
		public static void CompositionExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** COMPOSITION EXAMPLES PRACTICE *********** \n");

			var animal = new Animal();

			var dog = new Dog(animal, "Dog", "BowWow!");
			var cat = new Cat(animal, "Cat", "Meow!");
			var mouse = new Mouse(animal, "Mouse", "Squeek!");

			dog.OnSpeak();
			cat.OnWalk();
			mouse.OnRun();
		}

		public class Animal
		{
			public string Run()
			{ return "is running."; }
			public string Walk()
			{ return "is walking."; }
			public string Speak(string speak)
			{ return $"says '{speak}'"; }
		}

		//////////////////////////////////////////////////////////////////

		public class Dog
		{
			private Animal _animal;
			private string _animalType;
			private string _animalSpeak;
			public Dog(Animal animal, string animalType, string animalSpeak)
			{
				_animal = animal;
				_animalType = animalType;
				_animalSpeak = animalSpeak;
			}
			public void OnRun()
			{ Console.WriteLine($"The {_animalType} {_animal.Run()}"); }
			public void OnWalk()
			{ Console.WriteLine($"The {_animalType} {_animal.Walk()}"); }
			public void OnSpeak()
			{ Console.WriteLine($"The {_animalType} {_animal.Speak(_animalSpeak)}"); }
		}

		public class Cat
		{
			private Animal _animal;
			private string _animalType;
			private string _animalSpeak;
			public Cat(Animal animal, string animalType, string animalSpeak)
			{
				_animal = animal;
				_animalType = animalType;
				_animalSpeak = animalSpeak;
			}
			public void OnRun()
			{ Console.WriteLine($"The {_animalType} {_animal.Run()}"); }
			public void OnWalk()
			{ Console.WriteLine($"The {_animalType} {_animal.Walk()}"); }
			public void OnSpeak()
			{ Console.WriteLine($"The {_animalType} {_animal.Speak(_animalSpeak)}"); }
		}

		public class Mouse
		{
			private Animal _animal;
			private string _animalType;
			private string _animalSpeak;
			public Mouse(Animal animal, string animalType, string animalSpeak)
			{
				_animal = animal;
				_animalType = animalType;
				_animalSpeak = animalSpeak;
			}
			public void OnRun()
			{ Console.WriteLine($"The {_animalType} {_animal.Run()}"); }
			public void OnWalk()
			{ Console.WriteLine($"The {_animalType} {_animal.Walk()}"); }
			public void OnSpeak()
			{ Console.WriteLine($"The {_animalType} {_animal.Speak(_animalSpeak)}"); }
		}
	}
}
