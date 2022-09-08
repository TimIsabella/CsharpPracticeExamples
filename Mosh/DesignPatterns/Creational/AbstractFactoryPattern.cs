using System;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class AbstractFactoryPattern
    {
        public static void AbstractFactoryMain()
        {
            Console.WriteLine("\n *********** ABSTRACT FACTORY PATTERN *********** \n");

            /// Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

            Console.WriteLine("\n--Factory 1:");
            var client1 = new Client();
            client1.ClientMethod(new ConcreteFactory1()); //Call methdod of 'Client' and pass in 'ConcreteFactory1' with interface extentions of 'IAbstractFactory'

            Console.WriteLine("\n--Factory 2:");
            var client2 = new Client();
            client2.ClientMethod(new ConcreteFactory2());
        }

        /////////// Interfaces ///////////
        public interface IAbstractFactory
        {
            IAbstractProductA CreateProductPartA();
            IAbstractProductB CreateProductPartB();
        }

        public interface IAbstractProductA
        { string UsefulFunctionA(); }

        public interface IAbstractProductB
        {
            string UsefulFunctionB();
            string AnotherUsefulFunctionB(IAbstractProductA collaborator);
        }

        /////////// Client ///////////
        public class Client
        {
            public void ClientMethod(IAbstractFactory factory)
            {
                //'factory' contains interface members of 'IAbstractFactory'
                IAbstractProductA productA = factory.CreateProductPartA();
                IAbstractProductB productB = factory.CreateProductPartB();

                Console.WriteLine(productA.UsefulFunctionA());
                Console.WriteLine(productB.UsefulFunctionB());
                Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            }
        }

        /////////// Concrete Factories ///////////
        //Factory #1
        class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreateProductPartA()
            { return new ConcreteProduct1A(); }

            public IAbstractProductB CreateProductPartB()
            { return new ConcreteProduct1B(); }
        }

        //Factory #2
        class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreateProductPartA()
            { return new ConcreteProduct2A(); }

            public IAbstractProductB CreateProductPartB()
            { return new ConcreteProduct2B(); }
        }

        /////////// Product #1 ///////////
        //Product A
        class ConcreteProduct1A : IAbstractProductA
        {
            public string UsefulFunctionA()
            { return "Product 1: Part A"; }
        }

        //Product B
        class ConcreteProduct1B : IAbstractProductB
        {
            public string UsefulFunctionB()
            { return "Product 1: Part B"; }

            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"Product 1: Part B -- combined with '{result}'";
            }
        }

        /////////// Product #2 ///////////
        //Product A
        class ConcreteProduct2A : IAbstractProductA
        {
            public string UsefulFunctionA()
            { return "Product 2: Part A"; }
        }

        //Product B
        class ConcreteProduct2B : IAbstractProductB
        {
            public string UsefulFunctionB()
            { return "Product 2: Part B"; }

            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"Product 2: Part B -- combined with '{result}'";
            }
        }
    }
}
