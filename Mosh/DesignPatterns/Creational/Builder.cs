using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class Builder
    {
        public static void BuilderMain()
        {
            Console.WriteLine("\n *********** BUILDER PATTERN *********** \n");
            /// 

            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            Toy toyA = toyACreator.GetToy();
            Console.WriteLine($"Model: {toyA.Model}, Material: {toyA.Body}, Head: {toyA.Head}, Limbs: {toyA.Limbs}, Legs: {toyA.Legs}");

            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            Toy toyB = toyBCreator.GetToy();
            Console.WriteLine($"Model: {toyB.Model}, Material: {toyB.Body}, Head: {toyB.Head}, Limbs: {toyB.Limbs}, Legs: {toyB.Legs}");
        }

        /////////// Director ///////////
        public class ToyCreator
        {
            private IToyBuilder _toyBuilder;
            
            public ToyCreator(IToyBuilder toyBuilder)
            {  _toyBuilder = toyBuilder; }

            public void CreateToy()
            {
                _toyBuilder.SetModel();
                _toyBuilder.SetHead();
                _toyBuilder.SetLimbs();
                _toyBuilder.SetBody();
                _toyBuilder.SetLegs();
            }

            public Toy GetToy()
            { return _toyBuilder.GetToy(); }
        }

        /////////// Product ///////////
        public class Toy
        {
            public string Model { get; set; }
            public string Head { get; set; }
            public string Limbs { get; set; }
            public string Body { get; set; }
            public string Legs { get; set; }
        }

        /////////// Concrete Builder ///////////
        public interface IToyBuilder
        {
            void SetModel();
            void SetHead();
            void SetLimbs();
            void SetBody();
            void SetLegs();
            Toy GetToy();
        }

        /////////// Concrete Class A ///////////
        public class ToyABuilder : IToyBuilder
        {
            Toy toy = new Toy();
            
            public void SetModel()
            { toy.Model = "TOY A"; }
            
            public void SetHead()
            { toy.Head = "1"; }
            
            public void SetLimbs()
            { toy.Limbs = "4"; }
            
            public void SetBody()
            { toy.Body = "Plastic"; }
            
            public void SetLegs()
            { toy.Legs = "2"; }
            
            public Toy GetToy()
            { return toy; }
        }

        /////////// Concrete Class B ///////////
        public class ToyBBuilder : IToyBuilder
        {
            Toy toy = new Toy();
            
            public void SetModel()
            { toy.Model = "TOY B"; }

            public void SetHead()
            { toy.Head = "2"; }
            
            public void SetLimbs()
            { toy.Limbs = "6"; }

            public void SetBody()
            { toy.Body = "Steel"; }

            public void SetLegs()
            { toy.Legs = "4"; }

            public Toy GetToy()
            { return toy; }
        }
    }
}
