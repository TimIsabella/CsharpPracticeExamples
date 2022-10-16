using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeExamples.DotNet.Fundamentals
{
	public class TaskExamples
	{
		public static void TaskExamplesMain()
		{
			Console.WriteLine("\n *********** TASK EXAMPLES *********** \n");
			///TPL -- 'Task Paralell Library'
			/// A task is a unit of work
			///'Task' is a .Net class which provides for asynchronus operations

			/// Below tasks all run asynchronusly
			///- They compete for the same console space which causes output overlapping issues

			/// /////////////////////////////////////////////////////// Starting Tasks ///////////////////////////////////////////////////////

			/// Create and start a 'Task' ///
			Console.WriteLine("Task Example #1 --");
			var taskLogic1 = new TaskLogic();
			Task.Factory.StartNew(() => taskLogic1.WriteChars('.'));	//'WriteChars()' contains a loop which runs 111 times

			//Readline can be used as a break to prevent the asynchronus overlap in the console
			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// Create new 'Task' and then start the task ///
			//- Logic passed in by lambda
			Console.WriteLine("Task Example #2 --");
			var taskLogic2 = new TaskLogic();
			var task2 = new Task(() => taskLogic2.WriteChars('?'));		//'WriteChars()' contains a loop which runs 111 times
			task2.Start();

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// Create new 'Task' and then start the task ///
			var taskLogic3 = new TaskLogic();

			//Instantiate new 'Task' while passing in action and state
			//'action' is the 'taskLogic3' method and 'state' is the string
			//'action' has no return type
			Console.WriteLine("Task Example #3 --");
			var task3 = new Task(taskLogic3.WriteObjects, "Object argument");		//'WriteObjects()' contains a loop which runs 111 times
			task3.Start();

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// Create new generic 'Task' ///
			var taskLogic4 = new TaskLogic();
			string text1 = "this is a string";
			string text2 = "this is also a strnig but longer";

			//Instantiate new 'Task' while passing in action and state
			//'action' is the 'taskLogic4' method and 'state' is the string
			//'action' method return type is 'int' so 'Task' must provide generic for 'int'
			Console.WriteLine("\nTask Example #4 --");
			var task4 = new Task<int>(taskLogic4.TextLength, text1);    //'TextLength()' runs only once therefore the task only runs once
			task4.Start();

			Console.WriteLine($"Task Example #4 -- Output length: '{task4.Result}'");	//Result if output of '.TextLength' return

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			//Same as above as above but automatically starts with '.StartNew'
			Task<int> task5 = Task.Factory.StartNew<int>(taskLogic4.TextLength, text2);    //'TextLength()' runs only once therefore the task only runs once

			Console.WriteLine($"Task Example #5 -- Output length: '{task5.Result}'");	//Result if output of '.TextLength' return

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// /////////////////////////////////////////////////////// Canceling Tasks ///////////////////////////////////////////////////////
			///- 'Cancellation token' is used to stop a task

			/// /////////// Create task with lambda containing infinite loop and cancel after 'ReadKey' ///////////
			var cancellationTokenSource1 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken1 = cancellationTokenSource1.Token;              //Create CTS cancel token with '.Token'

			var task6 = new Task(() =>
			{
				//Infinite loop
				int i = 0;
				while(true)
				{
					//'break' if '.IsCancellationRequested' is true
					if(cancelToken1.IsCancellationRequested) { break; }

					//Throw exception at 11 which breaks the loop
					if(i > 11) { throw new OperationCanceledException(); }

					Console.WriteLine($"Task Example #6 -- While loop index: '{i}'. Press any key to stop (throws exception at 11)."); i++;
					Thread.Sleep(500);
				}

			}, cancelToken1 ); //Second overload takes the cancel token

			task6.Start();						//Start
			Console.ReadKey();					//Wait for readkey
			cancellationTokenSource1.Cancel();  //Call CTS task to stop
			Console.WriteLine("Cancel token for Task Example #6 called!\n");

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// /////////// Create task with lambda containing infinite loop and cancel after 'ReadKey' ///////////
			var cancellationTokenSource2 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken2 = cancellationTokenSource2.Token;             //Create CTS cancel token with '.Token'

			var task7 = new Task(() =>
			{
				//Infinite loop
				int i = 0;
				while(true)
				{
					//Throw at token cancellation
					cancelToken2.ThrowIfCancellationRequested();
					Console.WriteLine($"Task Example #7 -- While loop index: '{i}'. Press any key to stop..."); i++;
					Thread.Sleep(500);
				}

			}, cancelToken2); //Second overload takes the cancel token

			task7.Start();						//Start
			Console.ReadKey();					//Wait for readkey
			cancellationTokenSource2.Cancel();  //Call CTS task to stop
			Console.WriteLine("Cancel token for Task Example #7 called!\n");

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// /////////// Get cancellation notification ///////////
			///- '.Register()' of token gets notified of cancellation by token

			//Create task with lambda containing infinite loop and cancel after 'ReadKey'
			var cancellationTokenSource3 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken3 = cancellationTokenSource3.Token;             //Create CTS cancel token with '.Token'

			var task8 = new Task(() =>
			{
				//Infinite loop
				int i = 0;
				while(true)
				{
					//Throw at token cancellation
					cancelToken3.ThrowIfCancellationRequested();
					Console.WriteLine($"Task Example #8 -- While loop index: '{i}'. Press any key to stop..."); i++;
					Thread.Sleep(500);
				}

			}, cancelToken3); //Second overload takes the cancel token

			task8.Start();						//Start
			Console.ReadKey();					//Wait for readkey
			cancellationTokenSource3.Cancel();  //Call CTS task to stop

			//'.Register()' notified of cancellation 
			cancelToken3.Register(() => 
			{ Console.WriteLine("Register Notification -- 'cancelToken3' called to cancel Task Example #8!\n"); });

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// /////////// Task pausing with '.Waitone()' ///////////
			///- '.WaitOne()' applied to '.WaitHandle' of cancel token pauses the task
			///- Interval in miliseconds can be applied to pause
			var cancellationTokenSource4 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken4 = cancellationTokenSource4.Token;             //Create CTS cancel token with '.Token'

			Task.Factory.StartNew(() =>
			{
				Console.WriteLine("Task Example #9 -- Wait handle applied...");
				cancelToken4.WaitHandle.WaitOne(2222);		  //Wait 2 seconds and then continue
				Console.WriteLine("Task Example #9 -- Wait handle released!\n");
			});

			Console.WriteLine("Press enter continue...\n");
			Console.ReadLine();

			/// /////////// Linked Cancel Token Sources ///////////
			///- Linking multiple cancel tokens to one token using '.CreateLinkedTokenSource()'
			///- Calling ANY of the tokens linked to the one calls the linked token

			var planned = new CancellationTokenSource();
			var preventative = new CancellationTokenSource();
			var emergency = new CancellationTokenSource();

			//Cancel tokens linked to 'linkedCancelToken'
			var linkedCancelToken = CancellationTokenSource.CreateLinkedTokenSource(planned.Token, preventative.Token, emergency.Token);

			Task.Factory.StartNew(() =>
			{               //Infinite loop
				int i = 0;
				while(true)
				{
					//Throw at token cancellation
					linkedCancelToken.Token.ThrowIfCancellationRequested();
					Console.WriteLine($"Task Example #10 -- While loop index: '{i}'."); i++;
					Thread.Sleep(500);
				}
			}, linkedCancelToken.Token);

			Console.ReadKey();

			//Any of the three below tokens cancel the above as they are linked 
			planned.Cancel();
			preventative.Cancel();
			emergency.Cancel();
		}

		/// ///////////////////////////////////////////////////////////////////////////////////////////////////

		public class TaskLogic
		{
			public void WriteChars(char charParam)
			{
				int i = 111;
				while(i > 0)
				{
					Console.Write(charParam);
					i--;
				}
			}

			public void WriteObjects(object objectParam)
			{
				int i = 111;
				while(i > 0)
				{
					Console.Write(objectParam);
					i--;
				}
			}

			public int TextLength(object objectParam)
			{
				Console.WriteLine($"Currently running task id '{Task.CurrentId}' is processing object '{objectParam}'...");
				return objectParam.ToString().Length;
			}
		}
	}
}