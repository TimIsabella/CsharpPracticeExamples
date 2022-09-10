using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
	public class ObserverPattern
	{
		public static void ObserverMain()
		{
			Console.WriteLine("\n *********** OBSERVER PATTERN *********** \n");
			/// Defines a one-to-many dependency between objects
			///- Defines a dependency between objects so that whenever an object changes its state, all its dependents are notified

			// Configure Observer pattern
			ConcreteSubject concreteSubject = new ConcreteSubject();
            ConcreteObserverA observerA1 = new ConcreteObserverA(concreteSubject, "Observer A1");
            ConcreteObserverA observerA2 = new ConcreteObserverA(concreteSubject, "Observer A2");
            ConcreteObserverA observerA3 = new ConcreteObserverA(concreteSubject, "Observer A3");

            ConcreteObserverB observerB1 = new ConcreteObserverB(concreteSubject, "Observer B1");
            ConcreteObserverB observerB2 = new ConcreteObserverB(concreteSubject, "Observer B2");
            ConcreteObserverB observerB3 = new ConcreteObserverB(concreteSubject, "Observer B3");

            concreteSubject.Attach(observerA1);
            concreteSubject.Attach(observerA2);
            concreteSubject.Attach(observerA3);

            // Change subject and notify observers
            concreteSubject.SubjectState = "ABC";
            concreteSubject.Notify();

            Console.WriteLine();

            concreteSubject.Attach(observerB1);
            concreteSubject.Attach(observerB2);
            concreteSubject.Detach(observerA3);

            concreteSubject.SubjectState = "123";
            concreteSubject.Notify();
        }

        ///////////////////////////////// Subject /////////////////////////////////

        /////////// Subject interface ///////////
        public interface ISubject
        {
            public void Attach(IObserver observer);
            public void Detach(IObserver observer);
            public void Notify();
        }

        /////////// Subject ///////////
        public class Subject : ISubject
        {
            private List<IObserver> observers = new List<IObserver>();
            
            public void Attach(IObserver observer)
            { observers.Add(observer); }

            public void Detach(IObserver observer)
            { observers.Remove(observer); }

            public void Notify()
            {
                foreach(IObserver observer in observers)
                { observer.Update(); }
            }
        }

        /////////// Concrete Subject ///////////
        public class ConcreteSubject : Subject
        {
            private string subjectState;

            // Get or set subject state
            public string SubjectState
            {
                get { return subjectState; }
                set { subjectState = value; }
            }
        }

        ///////////////////////////////// Observer /////////////////////////////////

        /////////// Observer interface ///////////
        public interface IObserver
        { public abstract void Update(); }

        /////////// Concrete Observer A ///////////
        public class ConcreteObserverA : IObserver
        {
            private string name;
            private string observerState;
            private ConcreteSubject subject;

            public ConcreteObserverA(ConcreteSubject subject, string name)
            {
                this.subject = subject;
                this.name = name;
            }

            public void Update()
            {
                observerState = subject.SubjectState;
                Console.WriteLine($"{name} state: {observerState}");
            }

            //Gets or sets subject
            public ConcreteSubject Subject
            {
                get { return subject; }
                set { subject = value; }
            }
        }

        /////////// Concrete Observer B ///////////
        public class ConcreteObserverB : IObserver
        {
            private string name;
            private string observerState;
            private ConcreteSubject subject;

            public ConcreteObserverB(ConcreteSubject subject, string name)
            {
                this.subject = subject;
                this.name = name;
            }

            public void Update()
            {
                observerState = subject.SubjectState;
                Console.WriteLine($"{name} state: {observerState}");
            }

            //Gets or sets subject
            public ConcreteSubject Subject
            {
                get { return subject; }
                set { subject = value; }
            }
        }
    }
}
