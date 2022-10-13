using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.SOLIDdesign
{
	public class DependencyInversion
	{
		public static void DependencyInversionMain()
		{
			Console.WriteLine("\n *********** DEPENDENCY INVERSION PRINCIPAL *********** \n");
			///- High level parts of the system should not depend on low level parts of the system directly
			///- Instead they should depend on abstraction

			var parent1 = new Person { Name = "John" };
			var child1_1 = new Person { Name = "Chris" };
			var child1_2 = new Person { Name = "Sally" };

			var parent2 = new Person { Name = "Parent2" };
			var child2_1 = new Person { Name = "Child1" };
			var child2_2 = new Person { Name = "Child2" };

			var relationships = new Relationships();
			relationships.AddParentAndChild(parent1, child1_1);
			relationships.AddParentAndChild(parent1, child1_2);

			relationships.AddParentAndChild(parent2, child2_1);
			relationships.AddParentAndChild(parent2, child2_2);

			var research1 = new Research(relationships, "John");
			var research2 = new Research(relationships, "Parent2");
		}

		//////////////////////////////////////////////////////////////////

		public class Person
		{ public string Name; }

		public enum Relationship
		{ Parent, Child, Sibiling }

		public interface IRelationshipsBrowser
		{ IEnumerable<Person> FindAllChildrenOf(string parentName); }

		/////////// HIGH-LEVEL MODULE ///////////
		public class Research
		{
			public Research(IRelationshipsBrowser browser, string parentName)
			{
				foreach(var person in browser.FindAllChildrenOf(parentName))
				{ Console.WriteLine($"{parentName} has a child named '{person.Name}'"); }
			}
		}

		/////////// LOW-LEVEL MODULE ///////////
		public class Relationships : IRelationshipsBrowser
		{
			private List<(Person, Relationship, Person)> _relationsTuple = new List<(Person, Relationship, Person)>();
			public List<(Person, Relationship, Person)> Relations { get { return _relationsTuple; } }

			public void AddParentAndChild(Person parent, Person child)
			{
				_relationsTuple.Add((parent, Relationship.Parent, child));
				_relationsTuple.Add((child, Relationship.Child, parent));
			}

			public IEnumerable<Person> FindAllChildrenOf(string parentName)
			{
				return Relations.Where(person => (person.Item1.Name == parentName && person.Item2 == Relationship.Parent))
								.Select(result => result.Item3);
			}
		}

		/*
		/////////// Complicated Way ///////////
		public class Relationships
		{
			private List<(Person, Relationship, Person)> _relationsTuple = new List<(Person, Relationship, Person)>();
			public List<(Person, Relationship, Person)> Relations { get { return _relationsTuple; } }

			public void AddParentAndChild(Person parent, Person child)
			{
				_relationsTuple.Add((parent, Relationship.Parent, child));
				_relationsTuple.Add((child, Relationship.Child, parent));
			}
		}

		public class Research
		{
			public Research(Relationships relationships, string parentName)
			{
				List<(Person, Relationship, Person)> researchRelations = relationships.Relations;

				foreach(var relation in researchRelations.Where(person => (person.Item1.Name == parentName && person.Item2 == Relationship.Parent)))
				{ Console.WriteLine($"{parentName} has a child named '{relation.Item3.Name}'"); }
			}
		}
		*/
	}
}