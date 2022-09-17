using System;
using System.Collections.Generic;

namespace PracticeExamples.DesignPatterns.Structural
{
    public class FlyweightPattern
    {
        public static void FlyweightMain()
        {
            Console.WriteLine("\n *********** FLYWEIGHT PATTERN *********** \n");

            /// Uses sharing to support large numbers of fine-grained objects efficiently
            ///- The Flyweight pattern has a single purpose: minimizing memory usage
            ///- An object that minimizes memory use by sharing data with other similar objects
            ///- State stored inside a flyweight object is 'intrinsic'
            ///- State passed into flyweight methods is 'extrinsic'

            /////////// Client ///////////
            //- Calculates or stores extrinsic flyweigth states
            //- A flyweight is a template object configured at runtime

            //'Extrinsic' state
            int extrinsicState = 22;
            FlyweightFactory factory = new FlyweightFactory(); //Instantiate 'factory' as 'FlyweightFactory' object

            // Work with different flyweight instances
            Flyweight flyweightX = factory.GetFlyweight("X");
            flyweightX.Operation(--extrinsicState);

            Flyweight flyweightY = factory.GetFlyweight("Y");
            flyweightY.Operation(--extrinsicState);

            Flyweight flyweightZ = factory.GetFlyweight("Z");
            flyweightZ.Operation(--extrinsicState);

            UnsharedConcreteFlyweight flyweightUnshared = new UnsharedConcreteFlyweight();
            flyweightUnshared.Operation(--extrinsicState);

        }

        /////////// Flyweight ///////////
        //- Interface through which flyweights can receive and act on extrinsic state
        public abstract class Flyweight
        { public abstract void Operation(int extrinsicState); }

        /////////// Flyweight Factory ///////////
        //- Creates and manages flyweight objects
        //- Ensures that flyweight are shared properly
        //- On client request, flyweight objects accesses an existing instance, or creates one if non exist

        public class FlyweightFactory
        {
            private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();

            public FlyweightFactory()
            {
                flyweights.Add("X", new ConcreteFlyweight());
                flyweights.Add("Y", new ConcreteFlyweight());
                flyweights.Add("Z", new ConcreteFlyweight());
            }

            public Flyweight GetFlyweight(string key)
            { return ((Flyweight)flyweights[key]); }
        }

        /////////// Concrete Flyweight ///////////
        //- Implements the Flyweight interface and adds storage for intrinsic state
        //- A ConcreteFlyweight object must be sharable
        //- Any state it stores must be intrinsic
        public class ConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicState)
            { Console.WriteLine("ConcreteFlyweight: " + extrinsicState); }
        }

        /////////// Unshared Concrete Flyweight ///////////
        public class UnsharedConcreteFlyweight : Flyweight
        {
            public override void Operation(int extrinsicState)
            { Console.WriteLine($"UnsharedConcreteFlyweight: {extrinsicState}"); }
        }
    }
}