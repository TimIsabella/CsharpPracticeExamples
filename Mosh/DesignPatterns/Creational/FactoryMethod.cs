using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class FactoryMethod
    {
        public static void FactoryMethodMain()
        {
            Console.WriteLine("\n *********** FACTORY METHOD PATTERN *********** \n");

            /////////// Client of 'Bike' ///////////
            string vehicleInput1 = "Bike";
            IVehicle type1 = VehicleFactory.GetVehicle(vehicleInput1);                                           //'type1' interface members extended to 'product' of that type passed in
            Console.WriteLine($"Selected vehicle '{type1.VehicleType()}' has {type1.NumberOfWheels()} wheels."); //'Product' members are accessed through the interface

            /////////// Client of 'Car' ///////////
            string vehicleInput2 = "Car";
            IVehicle type2 = VehicleFactory.GetVehicle(vehicleInput2);
            Console.WriteLine($"Selected vehicle '{type2.VehicleType()}' has {type2.NumberOfWheels()} wheels.");
        }

        /////////// Factory ///////////
        //- Returns 'product' of selected 'type' extended with interface members
        public class VehicleFactory
        {
            /////////// Creator ///////////
            public static IVehicle GetVehicle(string type)
            {
                //Instantiate 'objectType' with methods of interface
                IVehicle objectType = null;

                //'objectType' interface members are extended to the selected 'product' class
                if(type.ToLower().Equals("bike"))
                { objectType = new Bike(); }

                //'objectType' interface members are extended to the selected 'product' class
                if(type.ToLower().Equals("car"))
                { objectType = new Car(); }

                //'objectType' interface extended to 'product' class is returned
                return objectType;
            }
        }

        /////////// Product Interface /////////// 
        public interface IVehicle
        {
            string VehicleType();
            int NumberOfWheels();
        }

        /////////// Concrete Product of Bike ///////////
        public class Bike : IVehicle
        {
            public int NumberOfWheels()
            { return 2; }

            public string VehicleType()
            { return "bicycle"; }
        }

        /////////// Concrete Product of Car ///////////
        public class Car : IVehicle
        {
            public int NumberOfWheels()
            { return 4; }

            public string VehicleType()
            { return "automobile"; }
        }
    }
}
