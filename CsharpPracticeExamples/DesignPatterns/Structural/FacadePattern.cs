using System;

namespace PracticeExamples.DesignPatterns.Structural
{
    public class FacadePattern
    {
        public static void FacadeMain()
        {
            Console.WriteLine("\n *********** FACADE PATTERN *********** \n");

            /// Provides a unified interface to a set of interfaces in a subsystem
            ///- Defines a higher-level interface that makes the subsystem easier to use

            /////////// Client ///////////

            var subSystemOne = new SubSystemOne();
            var subSystemTwo = new SubSystemTwo();
            var subSystemThree = new SubSystemThree();
            var subSystemFour = new SubSystemFour();

            var facade = new Facade(subSystemOne, subSystemTwo, subSystemThree, subSystemFour);

            facade.MethodA(); //Contains calls to multiple methods of the above subsystems
            facade.MethodB(); //Contains calls to multiple methods of the above subsystems
        }

        /////////// Facade ///////////
        public class Facade
        {
            private SubSystemOne _one;
            private SubSystemTwo _two;
            private SubSystemThree _three;
            private SubSystemFour _four;

            public Facade(SubSystemOne one, SubSystemTwo two, SubSystemThree three, SubSystemFour four)
            {
                _one = one;
                _two = two;
                _three = three;
                _four = four;
            }

            public void MethodA()
            {
                Console.WriteLine("\nMethodA():");
                _one.MethodOne();
                _two.MethodTwo();
                _four.MethodFour();
            }

            public void MethodB()
            {
                Console.WriteLine("\nMethodB():");
                _two.MethodTwo();
                _three.MethodThree();
            }
        }

        /////////// SubSystems ///////////

        // Subsystem 1
        public class SubSystemOne
        {
            public void MethodOne()
            { Console.WriteLine("--SubSystemOne Method"); }
        }

        //Subsystem 2
        public class SubSystemTwo
        {
            public void MethodTwo()
            { Console.WriteLine("--SubSystemTwo Method");
            }
        }

        //Subsystem 3
        public class SubSystemThree
        {
            public void MethodThree()
            { Console.WriteLine("--SubSystemThree Method"); }
        }

        //Subsystem 4
        public class SubSystemFour
        {
            public void MethodFour()
            { Console.WriteLine("--SubSystemFour Method"); }
        }
    }
}