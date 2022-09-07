using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class AbstractFactory
    {
        public static void AbstractFactoryMain()
        {
            Console.WriteLine("\n *********** ABSTRACT FACTORY PATTERN *********** \n");

            Console.WriteLine("\n--Factory 1:");
            var client1 = new Client();
            client1.ClientMethod(new ConcreteFactory1()); //Call methdod of 'Client' and pass in 'ConcreteFactory1' with interface extentions of 'IAbstractFactory'

            Console.WriteLine("\n--Factory 2:");
            var client2 = new Client();
            client2.ClientMethod(new ConcreteFactory2());
        }

        public class Client
        {
            public void ClientMethod(IAbstractFactory factory)
            {
                //'factory' contains interface members of 'IAbstractFactory'
                IAbstractProductA productA = factory.CreateProductA();
                IAbstractProductB productB = factory.CreateProductB();

                Console.WriteLine(productB.UsefulFunctionB());
                Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            }
        }

        /////////// Interface ///////////
        public interface IAbstractFactory
        {
            IAbstractProductA CreateProductA();
            IAbstractProductB CreateProductB();
        }

        public interface IAbstractProductA
        { string UsefulFunctionA(); }

        public interface IAbstractProductB
        {
            string UsefulFunctionB();
            string AnotherUsefulFunctionB(IAbstractProductA collaborator);
        }

        /////////// Concrete Factory ///////////
        class ConcreteFactory1 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            { return new ConcreteProductA1(); }

            public IAbstractProductB CreateProductB()
            { return new ConcreteProductB1(); }
        }

        class ConcreteFactory2 : IAbstractFactory
        {
            public IAbstractProductA CreateProductA()
            { return new ConcreteProductA2(); }

            public IAbstractProductB CreateProductB()
            { return new ConcreteProductB2(); }
        }

        /////////// Product A ///////////
        class ConcreteProductA1 : IAbstractProductA
        {
            public string UsefulFunctionA()
            { return "The result of the product A1."; }
        }

        class ConcreteProductA2 : IAbstractProductA
        {
            public string UsefulFunctionA()
            { return "The result of the product A2."; }
        }

        /////////// Product B ///////////
        class ConcreteProductB1 : IAbstractProductB
        {
            public string UsefulFunctionB()
            { return "The result of the product B1."; }

            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"The result of the B1 collaborating with the ({result})";
            }
        }

        class ConcreteProductB2 : IAbstractProductB
        {
            public string UsefulFunctionB()
            { return "The result of the product B2."; }

            public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"The result of the B2 collaborating with the ({result})";
            }
        }
    }
}
