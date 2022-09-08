using System;
using System.Collections.Generic;

namespace PracticeExamples.DesignPatterns.Structural
{
	public class CompositePattern
	{
        public static void CompositeMain()
        {
            Console.WriteLine("\n *********** COMPOSITE PATTERN *********** \n");

            /// Composes objects into tree structures to represent part-whole hierarchies
            ///- This pattern lets clients treat individual objects and compositions of objects uniformly

            /////////// Client ///////////
            
            Composite root = new Composite("Root"); //Initial root
            root.Add(new Leaf("Leaf 1"));           //Add leaf onto root
            root.Add(new Leaf("Leaf 2"));           //Add leaf onto root
            root.Add(new Leaf("Leaf 3"));           //Add leaf onto root

            Composite node1 = new Composite("Branch 1");  //Create a branch 'node' onto the root
            node1.Add(new Leaf("Leaf 1"));                //Add leaf onto node1
            node1.Add(new Leaf("Leaf 2"));                //Add leaf onto node1
            node1.Add(new Leaf("Leaf 3"));                //Add leaf onto node1
            root.Add(node1);                              //Add node1 branch onto root

            Composite node2 = new Composite("Branch 2");  //Create a branch 'node' onto the node1
            node2.Add(new Leaf("Leaf 1"));                //Add leaf onto node2
            node2.Add(new Leaf("Leaf 2"));                //Add leaf onto node2
            node2.Add(new Leaf("Leaf 3"));                //Add leaf onto node2
            node1.Add(node2);                             //Add node2 branch onto node1

            Composite node3 = new Composite("Branch 3");  //Create a branch 'node' onto the the root
            node3.Add(new Leaf("Leaf 1"));                //Add leaf onto node3
            node3.Add(new Leaf("Leaf 2"));                //Add leaf onto node3
            node3.Add(new Leaf("Leaf 3"));                //Add leaf onto node3
            root.Add(node3);                              //Add node3 branch onto root

            ///////////

            Leaf newLeaf = new Leaf("Leaf NEW");  //Instantiate leaf
            node3.Add(newLeaf);                   //Add leaf onto node3 branch

            root.Display(2);   //Output tree from 'root'
        }

        /////////// Component (abstract container) ///////////
        // - Declares common operations for both simple and complex objects of a composition
        public abstract class Component
        {
            protected string name;

            public Component(string name)
            { this.name = name; }

            public abstract void Add(Component component);
            public abstract void Remove(Component component);
            public abstract void Display(int indent);
        }

        /////////// Composite (parent) ///////////
        // - Rrepresents the complex components that may have children
        public class Composite : Component
        {
            List<Component> components = new List<Component>();

            public Composite(string name) : base(name)
            { }

            public override void Add(Component component)
            { components.Add(component); }

            public override void Remove(Component component)
            { components.Remove(component); }

            public override void Display(int indent)
            {
                Console.WriteLine($"{new String('-', indent)} *{name}*");

                // Display each child component on this node
                foreach(Component component in components)
                { component.Display(indent * 2); }
            }
        }

        /////////// Leaf (child) ///////////
        // - Represents the end objects of a composition
        // - A leaf can't have any children
        public class Leaf : Component
        {
            public Leaf(string name) : base(name)
            { }

            public override void Add(Component component)
            { Console.WriteLine("Cannot add to a Leaf"); }
            
            public override void Remove(Component component)
            { Console.WriteLine("Cannot remove from a Leaf"); }
            
            public override void Display(int indent)
            { Console.WriteLine($"{new String('-', indent)} {name}"); }
        }
    }
}