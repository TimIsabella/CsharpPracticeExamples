using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

			///Below tasks all run asynchronusly
			///- They compete for the same console space which causes output overlapping issues
			var taskLogic = new TaskLogic();

			// Create and start a 'Task'
			Task.Factory.StartNew(() => taskLogic.WriteChars('.'));

			//Readline can be used as a break to prevent the asynchronus overlap
			//Console.ReadLine();

			// Create new 'Task' and then start the task
			//- Logic passed in by lambda
			var task1 = new Task(() => taskLogic.WriteChars('?'));
			task1.Start();

			//Console.ReadLine();

			// Create new 'Task' and then start the task
			//- Logic passed in as 'action' and 'state' by 'object'
			var task2 = new Task(taskLogic.WriteObjects, "Object argument");
			task2.Start();

			//Console.ReadLine();
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
				return objectParam.ToString().Length;
			}
		}
	}
}