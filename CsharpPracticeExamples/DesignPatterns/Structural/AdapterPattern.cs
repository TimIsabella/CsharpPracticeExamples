using System;

namespace PracticeExamples.DesignPatterns.Structural
{
    public class AdapterPattern
    {
        public static void AdapterMain()
        {
            Console.WriteLine("\n *********** ADAPTER PATTERN *********** \n");

            ///Converts the interface of a class into another interface clients expect
            ///- This pattern lets classes work together that couldnt otherwise because of incompatible interfaces
            ///- Lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class
            ///- The goal of the pattern is loosely coupling between 'client' and 'adaptee'
            
            /////////// Client by Interface ///////////
            Adaptee1 adaptee1 = new Adaptee1();         //Instantiate 'adaptee' class
            ITarget target1 = new Adapter1(adaptee1);   //Instantiate interface 'target' as 'Adapter' class with 'Adaptee' class passed in
            Console.WriteLine(target1.GetRequest());    //Call method of 'target' interface

            /////////// Client by Override ///////////
            Adaptee2 adaptee2 = new Adaptee2();         //Instantiate 'adaptee' class
            Target2 target2 = new Adapter2(adaptee2);   //Instantiate 'target' virtual class as 'Adapter' class
            Console.WriteLine(target2.GetRequest());    //Call method of 'target' overridden class
        }

        ///////////////////////////////// By Interface /////////////////////////////////

        /////////// Target ///////////
        // The 'Target' defines the domain-specific interface used by the client code
        public interface ITarget
        { string GetRequest(); }

        /////////// Adapter ///////////
        // The 'Adapter' makes the 'Adaptee' interface compatible with the 'Target' interface.
        class Adapter1 : ITarget
        {
            private readonly Adaptee1 _adaptee;

            public Adapter1(Adaptee1 adaptee)
            { _adaptee = adaptee; }

            public string GetRequest()
            { return $"Adapter1.GetRequest(): '{_adaptee.GetSpecificRequest()}'"; }
        }

        /////////// Adaptee ///////////
        // The 'Adaptee' contains some useful behavior, but its interface is
        // incompatible with the existing client code. The Adaptee needs some
        // adaptation before the client code can use it.
        public class Adaptee1
        {
            public string GetSpecificRequest()
            { return "Called Adaptee1.GetSpecificRequest()"; }
        }

        ///////////////////////////////// By Override /////////////////////////////////

        /////////// Target ///////////
        // 'virtual' class to be overridden
        public class Target2
        {
            public virtual string GetRequest()
            { return "Called 'virtual' Target2.GetRequest()"; }
        }

        /////////// Adapter ///////////
        // Inherits the 'virtual' class to override
        public class Adapter2 : Target2
        {
            private readonly Adaptee2 _adaptee;

            public Adapter2(Adaptee2 adaptee)
            { _adaptee = adaptee; }

            //Overrides the inherited method
            public override string GetRequest()
            { return $"Adapter2.GetRequest(): '{_adaptee.GetSpecificRequest()}'"; }
        }

        /////////// Adaptee ///////////
        public class Adaptee2
        {
            public string GetSpecificRequest()
            { return "Called Adaptee2.GetSpecificRequest()"; }
        }
    }
}