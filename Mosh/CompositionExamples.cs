using System;

namespace Mosh
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

			var compObj3 = new CompositionObject3(new MessageHandler());
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

		public class CompositionObject1
		{
			public void CompositionMethod(MessageHandler handler)
			{
				handler.Log("CompositionObject1: Message from method...");
			}
		}

		public class CompositionObject2
		{
			MessageHandler Handler;
			public CompositionObject2(MessageHandler handler)
			{
				Handler = handler;
			}

			public void CompositionMethod()
			{
				Handler.Log("CompositionObject2: Message from method...");
			}
		}

		public class CompositionObject3
		{
			MessageHandler Handler;
			string compMsg = "CompositionObject3: ";

			public CompositionObject3(MessageHandler handler)
			{
				Handler = handler;
			}

			public void CompositionMethod1(string msg)
			{
				Handler.Log(compMsg + msg);
			}

			public void CompositionMethod2(string msg)
			{
				Handler.Log(compMsg + msg);
			}

			public void CompositionMethod3(string msg)
			{
				Handler.Log(compMsg + msg);
			}
		}
	}
}
