using System;

namespace PracticeExamples
{
	public class CompositionExamples
	{
		public static void CompositionExamplesMain()
		{
			Console.WriteLine("\n *********** COMPOSITION *********** \n");

			var compObj1 = new CompositionObject1();
			compObj1.CompositionMethod(new MessageHandler());

			var handler = new MessageHandler();
			var compObj2 = new CompositionObject2(handler);
			compObj2.CompositionMethod();

			var compObj3 = new CompositionObject3(new MessageHandler(), "CompositionObject3: ");
			compObj3.CompositionMethod1("Method 1 message...");
			compObj3.CompositionMethod2("Method 2 message...");
			compObj3.CompositionMethod3("Method 3 message...");
		}

		public class MessageHandler
		{
			public void Log(string message)
			{
				Console.WriteLine(message);
			}
		}

		//////////////////////////////////////////////////////////////////

		//Directly by passing in the 'MessageHandler'
		public class CompositionObject1
		{
			public void CompositionMethod(MessageHandler handler)
			{ handler.Log("CompositionObject1: Message from method..."); }
		}

		//'MessageHandler' passed into constructor and stored in field
		public class CompositionObject2
		{
			private MessageHandler _handler;
			public CompositionObject2(MessageHandler handler)
			{ _handler = handler; }

			public void CompositionMethod()
			{ _handler.Log("CompositionObject2: Message from method..."); }
		}

		//'MessageHandler' passed into constructor and stored in field -- multiple parameters
		public class CompositionObject3
		{
			private MessageHandler _handler;
			private string _compMsg;

			public CompositionObject3(MessageHandler handler, string msgStr)
			{
				_handler = handler;
				_compMsg = msgStr;
			}

			public void CompositionMethod1(string msg)
			{ _handler.Log(_compMsg + msg); }

			public void CompositionMethod2(string msg)
			{ _handler.Log(_compMsg + msg); }

			public void CompositionMethod3(string msg)
			{ _handler.Log(_compMsg + msg); }
		}
	}
}
