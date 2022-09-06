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

            /////////// Client for product 1 ///////////
            var toy1Creator = new ToyCreator(new Toy1Builder()); //Instantiate 'Director' and pass in 'Concrete Builder' as interface
            toy1Creator.CreateToy();                             //Call 'Director' to construct 'Concrete Builder'
            Toy toy1 = toy1Creator.GetToy();                     //Call 'Director' to return completed 'Product'

            Console.WriteLine($"Model: {toy1.Model}, Material: {toy1.Body}, Head: {toy1.Head}, Limbs: {toy1.Limbs}, Legs: {toy1.Legs}");


            /////////// Client for product 2 ///////////
            var toy2Creator = new ToyCreator(new Toy2Builder());
            toy2Creator.CreateToy();
            Toy toy2 = toy2Creator.GetToy();

            Console.WriteLine($"Model: {toy2.Model}, Material: {toy2.Body}, Head: {toy2.Head}, Limbs: {toy2.Limbs}, Legs: {toy2.Legs}");
        }

        /////////// Director ///////////
        //- Defines order to call construction steps
        public class ToyCreator
        {
            private IToyBuilder _toyBuilder;
            
            //Extend members from 'Builder' interface for use
            //- Using an interface allows any 'Concrete Builder' class of the same signature to be used
            public ToyCreator(IToyBuilder toyBuilder) //
            {  _toyBuilder = toyBuilder; }

            //Call methods of 'Builder' interface
            public void CreateToy()
            {
                _toyBuilder.SetModel();
                _toyBuilder.SetHead();
                _toyBuilder.SetLimbs();
                _toyBuilder.SetBody();
                _toyBuilder.SetLegs();
            }

            //Return the completed product
            public Toy GetToy()
            { return _toyBuilder.GetToy(); }
        }

        /////////// Builder ///////////
        //- Declare 'product' construction steps for all 'builders'
        public interface IToyBuilder
        {
            void SetModel();
            void SetHead();
            void SetLimbs();
            void SetBody();
            void SetLegs();
            Toy GetToy();
        }

        /////////// Concrete Builder 1 ///////////
        
        public class Toy1Builder : IToyBuilder
        {
            private Toy _toy = new Toy();
            
            public void SetModel()
            { _toy.Model = "TOY 1"; }
            
            public void SetHead()
            { _toy.Head = "1"; }
            
            public void SetLimbs()
            { _toy.Limbs = "4"; }
            
            public void SetBody()
            { _toy.Body = "Plastic"; }
            
            public void SetLegs()
            { _toy.Legs = "2"; }
            
            public Toy GetToy()
            { return _toy; }
        }

        /////////// Concrete Builder 1 ///////////
        public class Toy2Builder : IToyBuilder
        {
            private Toy _toy = new Toy();
            
            public void SetModel()
            { _toy.Model = "TOY 2"; }

            public void SetHead()
            { _toy.Head = "2"; }
            
            public void SetLimbs()
            { _toy.Limbs = "6"; }

            public void SetBody()
            { _toy.Body = "Steel"; }

            public void SetLegs()
            { _toy.Legs = "4"; }

            public Toy GetToy()
            { return _toy; }
        }

        /////////// Product ///////////
        //- Resulting object to hydrate
        //- Returned as the completed 'product' of the builder
        public class Toy
        {
            public string Model { get; set; }
            public string Head { get; set; }
            public string Limbs { get; set; }
            public string Body { get; set; }
            public string Legs { get; set; }
        }
    }
}
