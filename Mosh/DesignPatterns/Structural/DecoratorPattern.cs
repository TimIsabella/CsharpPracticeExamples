using System;

namespace PracticeExamples.DesignPatterns.Structural
{
    public class DecoratorPattern
    {
        public static void DecoratorMain()
        {
            Console.WriteLine("\n *********** DECORATOR PATTERN *********** \n");

            ///Attaches additional responsibilities to an object dynamically
            ///- Provides a flexible alternative to subclassing for extending functionality

            /////////// Client ///////////

            // Create ConcreteComponent and two Decorators
            var component = new ConcreteComponent();
            var concreteDecoratorA = new ConcreteDecoratorA();
            var concreteDecoratorB = new ConcreteDecoratorB();
            var concreteDecoratorC = new ConcreteDecoratorC();

            // Link decorators
            Console.WriteLine("-----------Begin-----------");
            concreteDecoratorA.SetComponent(component);
            concreteDecoratorA.Operation();
            Console.WriteLine("-----------End-----------\n");

            Console.WriteLine("-----------Begin-----------");
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorB.Operation();
            Console.WriteLine("-----------End-----------\n");

            Console.WriteLine("-----------Begin-----------");
            concreteDecoratorC.SetComponent(concreteDecoratorB);
            concreteDecoratorC.Operation();
            Console.WriteLine("-----------End-----------\n");
        }

        /////////// Base Decorator (abstract) ///////////
        // Maintains a reference to a 'Component' and defines an interface that conforms to Component's interface
        public abstract class BaseDecorator : Component
        {
            protected Component _component;

            //Set the 'Component' to '_component'
            public void SetComponent(Component component)
            {
                Console.WriteLine($"BaseDecorator: setting 'component'");
                _component = component;
            }

            public override void Operation()
            {
                if(_component != null)
                {
                    Console.WriteLine("BaseDecorator: 'component' empty and calling '.Operation()'");
                    _component.Operation();
                }
            }
        }

        /////////// Component (abstract) ///////////
        // Interface for objects that can have responsibilities added to them dynamically
        //- Can also be an interface
        public abstract class Component
        { public abstract void Operation(); }

        /////////// Concrete Component ///////////
        // An object to which additional responsibilities can be attached
        public class ConcreteComponent : Component
        {
            public override void Operation()
            { Console.WriteLine("ConcreteComponent: '.Operation()' method called"); }
        }

        /////////// Concrete Decorators ///////////
        //- Defines extra behaviors that can be dynamically added

        public class ConcreteDecoratorA : BaseDecorator
        {
            
            public override void Operation() //Override '.Operation()' method of 'BaseDecorator'
            {
                base.Operation(); //Call '.Operation()' method of 'BaseDecorator'
                Console.WriteLine("--ConcreteDecoratorA: '.Operation()' method called");

                NewBehavior();
            }

            void NewBehavior()
            { Console.WriteLine("---ConcreteDecoratorA: '.NewBehavior()' method called"); }
        }

        public class ConcreteDecoratorB : BaseDecorator
        {
            public override void Operation() //Override '.Operation()' method of 'BaseDecorator'
            {
                base.Operation(); //Call '.Operation()' method of 'BaseDecorator'
                Console.WriteLine("--ConcreteDecoratorB: '.Operation()' method called");

                AddedBehavior();
            }

            void AddedBehavior()
            { Console.WriteLine("---ConcreteDecoratorB: '.AddedBehavior()' method called"); }
        }

        public class ConcreteDecoratorC : BaseDecorator
        {
            public override void Operation() //Override '.Operation()' method of 'BaseDecorator'
            {
                base.Operation(); //Call '.Operation()' method of 'BaseDecorator'
                Console.WriteLine("--ConcreteDecoratorC: '.Operation()' method called");

                AdditionalBehavior();
            }

            void AdditionalBehavior()
            { Console.WriteLine("---ConcreteDecoratorC: '.AdditionalBehavior()' method called"); }
        }
    }
}