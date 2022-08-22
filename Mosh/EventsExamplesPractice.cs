using System;

namespace Mosh
{
	public class EventsExamplesPractice
	{
		public static void EventsExamplesPracticeMain()
		{
			Console.WriteLine("\n *********** EVENT PRACTICE *********** \n");

			var cat = new Cat() { Id = 1, Name = "Gato", Health = 100};

			cat.OnHealthChange += EventMethodOnHealthChange; //'subscribe' to event: Adds delegates for event to call
			cat.OnKilled += EventMethodOnKilled;

			cat.Health = 111;
			cat.Health = 66;
			cat.Health = 22;
			cat.Health = -1;
		}

		public class Cat
		{
			private int _health;
		
			public int Id { get; set; }
			public string Name { get; set; }

			//Events - Take a single 'int' parameter
			public event EventHandler<int> OnHealthChange;
			public event EventHandler<int> OnKilled;

			//Want to be notified every time the cat health changes
			public int Health { 
								get { return _health; }
								set { 
										_health = value;

										//Call 'OnHealthChange' delegate for 'this' instance of cat object on 'health' change
										//'?' to check for null and then use '.Invoke()'
										if(_health > 0) OnHealthChange?.Invoke(this, _health);
										else OnKilled?.Invoke(this, _health);
									}
							  }
		}

		/////////// Event Methods ///////////

		private static void EventMethodOnHealthChange(object sender, int e)
		{
			//'sender' represents the instance of the object on which the event is called 
			var cat = (Cat)sender;

			Console.WriteLine($"{cat.Name}'s health changed to {e}!"); //'e' is the return for the 'health' integer
		}

		private static void EventMethodOnKilled(object sender, int e)
		{
			var cat = (Cat)sender;
			Console.WriteLine($"{cat.Name} has been killed!");
		}
	}
}