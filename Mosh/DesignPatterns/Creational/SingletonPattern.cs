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
            static Singleton instance;
            private int _num;

            //A singleton's constructor is 'private' to prevent directly creating 'new' instances
            private Singleton(int num)
            { _num = num; }

            public static Singleton Instance(int num)
            {
                if(instance == null)
                { instance = new Singleton(num); }
                
                return instance;
            }

            //A singleton should define some business logic, which can be executed on its instance
            public void SomeBusinessLogic()
            {
                //
            }
        }

    }
}
