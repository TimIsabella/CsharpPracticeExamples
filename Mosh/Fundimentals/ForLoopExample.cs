using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples
{
	public class ForLoopExample
	{
		public static void ForLoopExampleMain()
		{
			Console.WriteLine("\n *********** FOR LOOP *********** \n");

			int[] intsForLoop = { 11, 22, 33, 44, 55 };

			for(int i = 0; i < intsForLoop.Length; i++)
			{
				Console.WriteLine("intsForLoop index {0} = {1}", i, intsForLoop[i]);
			}
		}
	}
}
