using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mosh
{
    public class AsyncAwaitExamples
    {
        public static void AsyncAwaitExamplesMain()
        {
            InitiateAsyncMethod();
            InitiateCooking();

            //Thread pausing and asynchronus processing
            /*
            //InitiateCooking().Wait(); -- '.Wait()'  - waits for to completion before continuing following code
            Thread.Sleep(3333);         -- '.Sleep()' - stops ALL thread processes in the program
            Task.Delay(3333);           -- '.Delay()' - pauses thread process at the current scope (used for 'async' processing)
            await Task.Delay(11);       -- 'await'    - like a pause, stops process in current scope but allows other processes to continue                  
            */

            Thread.Sleep(3333);
        }

        //'async' cannot return void
        //- 'Task' is an async based object
        public static async Task InitiateAsyncMethod()
        {
            //'await' delays the process synchronusly, but allows other processing in other threads to continue asynchronusly
            Console.WriteLine("InitiateAsyncMethod: Starting");
            
            await Task.Delay(11);
            Console.WriteLine("InitiateAsyncMethod: AsyncMethod1");
            AsyncMethod1();
            await Task.Delay(11);
            Console.WriteLine("InitiateAsyncMethod: AsyncMethod2");
            AsyncMethod2();
            await Task.Delay(11);
            Console.WriteLine("InitiateAsyncMethod: AsyncMethod3");
            AsyncMethod3();

            Console.WriteLine("InitiateAsyncMethod: Finished");
        }

        public static async Task AsyncMethod1()
        {
            Console.WriteLine("AsyncMethod1: Starting");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod1: Delay 1");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod1: Delay 2");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod1: Delay 3");

            Console.WriteLine("AsyncMethod1: Finished");
        }

        public static async Task AsyncMethod2()
        {
            Console.WriteLine("AsyncMethod2: Starting");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod2: Delay 1");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod2: Delay 2");
            await Task.Delay(333);
            Console.WriteLine("AsyncMethod2: Delay 3");

            Console.WriteLine("AsyncMethod2: Finished");
        }

        public static async Task AsyncMethod3()
        {
            Console.WriteLine("AsyncMethod3: Starting");

            for(int i = 0; i < 3; i++)
            {
                await Task.Delay(333);
                Console.WriteLine($"AsyncMethod3: Delay {i}");
            }

            Console.WriteLine("AsyncMethod3: Finished");
        }

        //////////////////////////////////////////////////////////////////
        public class Egg { }

        public static async Task<Egg> InitiateCooking()
        {
            Console.WriteLine("Preparing to cook eggs...");

            //'await' cannot return void
            Egg eggs = await FryEggsAsync(2);

            Console.WriteLine("Eggs are ready!");

            return eggs;
        }

        public static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Cooking eggs: Warming the egg pan...");
            await Task.Delay(555);
            Console.WriteLine($"Cooking eggs: Cracking {howMany} eggs");
            await Task.Delay(555);
            Console.WriteLine("Cooking eggs: Cooking the eggs...");
            await Task.Delay(555);
            Console.WriteLine("Cooking eggs: Put eggs on plate");

            return new Egg();
        }
    }
}
