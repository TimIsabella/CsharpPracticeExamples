using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class SingletonPattern
    {
        public static void SingletonMain()
        {
            Console.WriteLine("\n *********** SINGLETON PATTERN *********** \n");
            /// A singleton is a class which only allows a single instance of itself to be created, while providing a global access point to that instance

            /////////// Client ///////////

            //Constructor is 'protected' -- cannot use new
            //- Calls the '.Instance()' method directly which returns a new instance of 'Singleton'
            var singleton1 = Singleton.Instance(123);

            //Subsequent calls to '.Instance()' returns the original instantiation
            var singleton2 = Singleton.Instance(456);
            
            //Test for same instance
            if(singleton1 == singleton2)
            { Console.WriteLine("Objects are the same instance"); }
            else
            { Console.WriteLine("Objects are NOT the same instance"); }
        }

        /////////// Singleton ///////////
        public class Singleton
        {
            //A singleton's instance is stored in a static field
            //- Marked as 'static' ensures that the Singleton can only be instantiated one time
            //- Subsequent calles to '.Instance()' returns the SAME original instantiation
            private static Singleton _instance;
            private int _num;

            //A singleton's constructor is 'private' to prevent directly creating 'new' instances
            private Singleton(int num)
            { _num = num; }

            public static Singleton Instance(int num)
            {
                if(_instance == null)
                { _instance = new Singleton(num); }

                return _instance;
            }

            //A singleton should define some business logic, which can be executed on its instance
            private void SomeBusinessLogic()
            { }
        }
    }
}
