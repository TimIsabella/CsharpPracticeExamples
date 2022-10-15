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

			/// Create and start a 'Task' ///
			var taskLogic1 = new TaskLogic();
			Task.Factory.StartNew(() => taskLogic1.WriteChars('.'));

			//Readline can be used as a break to prevent the asynchronus overlap
			//Console.ReadLine();

			/// Create new 'Task' and then start the task ///
			//- Logic passed in by lambda
			var taskLogic2 = new TaskLogic();
			var task1 = new Task(() => taskLogic2.WriteChars('?'));
			task1.Start();

			//Console.ReadLine();

			/// Create new 'Task' and then start the task ///
			var taskLogic3 = new TaskLogic();

			//Instantiate new 'Task' while passing in action and state
			//'action' is the 'taskLogic3' method and 'state' is the string
			//'action' has no return type
			var task2 = new Task(taskLogic3.WriteObjects, "Object argument");
			task2.Start();

			Console.WriteLine("\nPress any key to continue...");
			Console.ReadLine();

			/// Create new generic 'Task' ///
			var taskLogic4 = new TaskLogic();
			string text1 = "testing";
			string text2 = "this";

			//Instantiate new 'Task' while passing in action and state
			//'action' is the 'taskLogic4' method and 'state' is the string
			//'action' method return type is 'int' so 'Task' must provide generic for 'int'
			var task3 = new Task<int>(taskLogic4.TextLength, text1);
			task3.Start();

			Console.WriteLine($"Task 3 output length: '{task3.Result}'"); //Result if output of '.TextLength' return

			//Same as above as above but automatically starts with '.StartNew'
			Task<int> task4 = Task.Factory.StartNew<int>(taskLogic4.TextLength, text2);

			Console.WriteLine($"Task 4 output length: '{task4.Result}'"); //Result if output of '.TextLength' return

			Console.WriteLine("\nPress any key to continue...");
			Console.ReadLine();

			/// Canceling Tasks ///
			///- 'Cancellation token' is used to stop a task

			/////////// Create task with lambda containing infinite loop and cancel after 'ReadKey' ///////////
			var cancellationTokenSource1 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken1 = cancellationTokenSource1.Token;              //Create CTS cancel token with '.Token'

			var infiniteTask = new Task(() =>
					{
						//Infinite loop
						int i = 0;
						while(true)
						{
							Console.WriteLine($"While loop index: '{i}'. Press any key to stop (automatically stops at 11111)."); i++;

							if(cancelToken1.IsCancellationRequested) //'break' if '.IsCancellationRequested' is true
							{ break; }

							if(i > 11111)                           //Throw exception at 11111 which breaks the loop
							{ throw new OperationCanceledException(); }
						}

					}, cancelToken1 ); //Second overload takes the cancel token

			infiniteTask.Start();

			Console.ReadKey();
			cancellationTokenSource1.Cancel(); //Call CTS task to stop

			/////////// Create task with lambda containing infinite loop and cancel after 'ReadKey' ///////////
			var cancellationTokenSource2 = new CancellationTokenSource();  //Instantiate 'CancellationTokenSource' (CTS)
			var cancelToken2 = cancellationTokenSource2.Token;             //Create CTS cancel token with '.Token'

			var exceptionTask = new Task(() =>
			{
				//Infinite loop
				int i = 0;
				while(true)
				{
					Console.WriteLine($"While loop index: '{i}'. Will throw token cancellation at 111.");
					i++;

					cancelToken2.ThrowIfCancellationRequested(); //Throw at token cancellation
				}

			}, cancelToken2); //Second overload takes the cancel token

			exceptionTask.Start();

			Console.ReadKey();
			cancellationTokenSource2.Cancel(); //Call CTS task to stop

			/////////// Get cancellation notification ///////////
			//'.Register()' of token gets notified of cancellation by token
			cancelToken2.Register(() => 
			{ 
				Console.WriteLine("cancelToken2 task cancelled"); 
			});

			Console.ReadKey();
		}

		///////////////////////////////////////////////////////////////////////////////////////////////////

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
				Console.WriteLine($"\nCurrent Task Id {Task.CurrentId} is currently processing object '{objectParam}'...");
				return objectParam.ToString().Length;
			}
		}
	}
}