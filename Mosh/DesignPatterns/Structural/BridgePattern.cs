using System;

namespace PracticeExamples.DesignPatterns.Structural
{
    public class BrdigePattern
    {
        public static void BridgeMain()
        {
            Console.WriteLine("\n *********** BRIDGE PATTERN *********** \n");

            ///Lets you split a large class or related set of classes into two separate hierarchies
            ///- Results in an abstraction and implementation which can be developed independently of each other

            /////////// Client ///////////

            Abstraction abstraction = new RefinedAbstraction(); //Instantiate 'abstraction' as 'RefinedAbstraction()' class which inherits 'Abstraction' class

            //'Set implementation' and call
            abstraction.Implementor = new ConcreteImplementorA(); //Concrete class passed into property
            abstraction.Operation();

            //'Change implemention' and call
            abstraction.Implementor = new ConcreteImplementorB(); //Concrete class passed into property
            abstraction.Operation();
        }

        /// ////////////////////////////// Bridge /////////////////////////////////

        /////////// Abstraction (part of the 'bridge') ///////////
        //- High-level control logic
        public class Abstraction
        {
            protected Implementor _implementor;

            public Implementor Implementor
            { set { _implementor = value; } } //Set '_implementor' 

            public virtual void Operation() //'Implementor' contains abstract '.Operatrion()' method
            { _implementor.Operation(); }
        }

        /////////// Implementation (part of the 'bridge') ///////////
        //- Declares the interface that's common for all concerete implementations
        public abstract class Implementor
        { public abstract void Operation(); }

        /// //////////////////////////////////////////////////////////////////////////

        /////////// RefinedAbstraction ///////////
        //- Provide variants of control logic
        public class RefinedAbstraction : Abstraction
        {
            public override void Operation() //Overrides abstract '.Operatrion()' method from 'Abstract'
            { _implementor.Operation(); }
        }

        /////////// Concrete Classes ///////////
        //- Contains platform specific code

        public class ConcreteImplementorA : Implementor //Inherits 'Implementor' abstract class containing '.Operation()' abstract method
        {
            public override void Operation()
            { Console.WriteLine("ConcreteImplementorA Operation"); }
        }

        public class ConcreteImplementorB : Implementor
        {
            public override void Operation()
            { Console.WriteLine("ConcreteImplementorB Operation"); }
        }






        /*
        public static void BridgeMain()
        {
            Console.WriteLine("\n *********** BRIDGE PATTERN *********** \n");

            ///Lets you split a large class or related set of classes into two separate hierarchies
            ///- Results in an abstraction and implementation which can be developed independently of each other

            // Create RefinedAbstraction
            var customers = new Customers();

            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
        }

        //'Abstraction' class
        public class CustomersBase
        {
            private DataObject _dataObject;

            public DataObject Data
            {
                set { _dataObject = value; }
                get { return _dataObject; }
            }

            public virtual void Next()
            { _dataObject.NextRecord(); }

            public virtual void Prior()
            { _dataObject.PriorRecord(); }

            public virtual void Add(string customer)
            { _dataObject.AddRecord(customer); }

            public virtual void Delete(string customer)
            { _dataObject.DeleteRecord(customer); }

            public virtual void Show()
            { _dataObject.ShowRecord(); }

            public virtual void ShowAll()
            { _dataObject.ShowAllRecords(); }
        }

        //'RefinedAbstraction' class
        public class Customers : CustomersBase
        {
            public override void ShowAll()
            {
                // Add separator lines
                Console.WriteLine();
                Console.WriteLine("------------------------");
                base.ShowAll();
                Console.WriteLine("------------------------");
            }
        }

        //'Implementor' abstract class
        public abstract class DataObject
        {
            public abstract void NextRecord();
            public abstract void PriorRecord();
            public abstract void AddRecord(string name);
            public abstract void DeleteRecord(string name);
            public abstract string GetCurrentRecord();
            public abstract void ShowRecord();
            public abstract void ShowAllRecords();
        }

        //'ConcreteImplementor' class
        public class CustomersData : DataObject
        {
            private readonly List<string> _customers = new List<string>();
            private int _current = 0;
            private string _city;

            public CustomersData(string city)
            {
                _city = city;

                // Loaded from a database 
                _customers.Add("Jim Jones");
                _customers.Add("Samual Jackson");
                _customers.Add("Allen Good");
                _customers.Add("Ann Stills");
                _customers.Add("Lisa Giolani");
            }

            public override void NextRecord()
            {
                if(_current <= _customers.Count - 1)
                { _current++; }
            }

            public override void PriorRecord()
            {
                if(_current > 0)
                { _current--; }
            }

            public override void AddRecord(string customer)
            { _customers.Add(customer); }

            public override void DeleteRecord(string customer)
            { _customers.Remove(customer); }

            public override string GetCurrentRecord()
            { return _customers[_current]; }

            public override void ShowRecord()
            { Console.WriteLine(_customers[_current]); }

            public override void ShowAllRecords()
            {
                Console.WriteLine("Customer City: " + _city);

                foreach(string customer in _customers)
                { Console.WriteLine(" " + customer); }
            }

            */

        /*
        public static void BridgeMain()
        {
            Console.WriteLine("\n *********** BRIDGE PATTERN *********** \n");

            ///Lets you split a large class or related set of classes into two separate hierarchies
            ///- Results in an abstraction and implementation which can be developed independently of each other

            var client = new Client();
            Abstraction abstraction;  //Field of class 'Abstraction' created to be used below

            abstraction = new Abstraction(new ConcreteImplementationA()); //'Abstraction' takes a class extended by 'IImplementation' interface
            client.ClientCode(abstraction);                               //'client' works with any pre-configured abstraction-implementation combination

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }

        // Concrete class 'ExtendedAbstraction' inherits from Abstraction
        //- 'Abstraction' class defines the interface for the 'control' part of the two class hierarchies
        //- Maintains a reference to an object of the implementation hierarchy
        //- Delegates all of the real work to this object
        class Abstraction
        {
            protected IImplementation _implementation;

            public Abstraction(IImplementation implementation)
            { _implementation = implementation; }

            public virtual string Operation()
            {
                return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
            }
        }

        // You can extend the Abstraction without changing the Implementation classes.
        class ExtendedAbstraction : Abstraction
        {
            public ExtendedAbstraction(IImplementation implementation) : base(implementation)
            { }

            public override string Operation()
            {
                return "ExtendedAbstraction: Extended operation with:\n" + _implementation.OperationImplementation();
            }
        }

        // The Implementation defines the interface for all implementation classes.
        //- It doesn't have to match the Abstraction's interface. In fact, the two
        // interfaces can be entirely different. Typically the Implementation
        // interface provides only primitive operations, while the Abstraction
        // defines higher- level operations based on those primitives.
        public interface IImplementation
        { string OperationImplementation(); }

        // Each Concrete Implementation corresponds to a specific platform and implements 'IImplementation' using that platform's API
        class ConcreteImplementationA : IImplementation
        {
            public string OperationImplementation()
            { return "ConcreteImplementationA: The result in platform A.\n\n"; }
        }

        class ConcreteImplementationB : IImplementation
        {
            public string OperationImplementation()
            { return "ConcreteImplementationA: The result in platform B.\n\n"; }
        }

        class Client
        {
            // Except for the initialization phase, where an Abstraction object gets
            // linked with a specific Implementation object, the client code should
            // only depend on the Abstraction class. This way the client code can
            // support any abstraction-implementation combination.
            public void ClientCode(Abstraction abstraction)
            { Console.Write(abstraction.Operation()); }
        }
        */
    }
}