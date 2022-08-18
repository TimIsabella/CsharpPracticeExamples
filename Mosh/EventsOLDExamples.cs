using System;

namespace Mosh
{
	public class EventsExamples
	{
		public static void EventsExamplesMain()
		{
			Console.WriteLine("\n *********** EVENT *********** \n");

			var classForEvent = new ClassForEvent();

			//Events are triggered in sequence of registration
			classForEvent.Event += OnEventTriggered1;   //Register 'OnEventTriggered1' with 'Event'
			classForEvent.Event += OnEventTriggered2;   //Register 'OnEventTriggered2' with 'Event'
			classForEvent.Event += OnEventTriggered3;   //Register 'OnEventTriggered3' with 'Event'

			classForEvent.InitiateEventSequence();
		}

		//DELEGATE
		//Declare delegate for event
		//Specifies the signature for the event in 'HandlerForEvent':
		//In this case, it is a method with no parameters
		public delegate void HandlerForEvent();

		//Event 'publisher class'
		public class ClassForEvent
		{
			public void InitiateEventSequence()
			{
				Console.WriteLine("Initiating event...");
				CallEvent();
			}

			//EVENT
			//Declare event 'Event' of 'HandlerForEvent'
			public event HandlerForEvent Event;

			//Method for event
			//Event methods must be 'protected' and 'virtual'
			//Event methods are named as verbs like 'On Action'
			protected virtual void CallEvent()
			{
				Console.WriteLine("Checking 'EventTrigger' for null...");

				//'Invoking an event' by using the event name 'Event'
				//Invoking can ONLY be done from within the same class as the declared event
				if(Event != null) Event.Invoke();
				else Console.WriteLine("No events registered.");
			}
		}

		/////////// Event Methods ///////////

		public static void OnEventTriggered1()
		{ Console.WriteLine("Event 1 Triggered!"); }

		public static void OnEventTriggered2()
		{ Console.WriteLine("Event 2 Triggered!"); }

		public static void OnEventTriggered3()
		{ Console.WriteLine("Event 3 Triggered!"); }
	}
}