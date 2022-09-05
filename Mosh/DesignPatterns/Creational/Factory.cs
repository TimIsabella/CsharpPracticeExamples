using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamples.DesignPatterns.Creational
{
    public class Factory
    {
        public static void FactoryMain()
        {
            Console.WriteLine("\n *********** FACTORY PATTERN *********** \n");
            /// 

            String vehicleInput = "Rickshaw";
            IVehicle Type = VehicleFactory.GetVehicle(vehicleInput);
            Console.WriteLine($"Selected vehicle '{Type.VehicleType()}' has {Type.NumberOfWheels()} wheels.");
        }

        public interface IVehicle
        {
            String VehicleType();
            int NumberOfWheels();
        }

        public class VehicleFactory
        {
            public static IVehicle GetVehicle(String Type)
            {
                IVehicle objectType = null;

                if(Type.ToLower().Equals("bike"))
                { objectType = new Bike(); }

                if(Type.ToLower().Equals("car"))
                { objectType = new Car(); }

                if(Type.ToLower().Equals("rickshaw"))
                { objectType = new Rickshaw(); }

                return objectType;
            }
        }

        /////////// Concrete Bike Class ///////////
        public class Bike : IVehicle
        {
            private readonly int _wheels;

            public Bike()
            { _wheels = 2; }

            public int NumberOfWheels()
            { return _wheels; }

            public string VehicleType()
            { return "Bike"; }
        }

        /////////// Concrete Car Class ///////////
        public class Car : IVehicle
        {
            private readonly int _wheels;

            public Car()
            { _wheels = 4; }

            public int NumberOfWheels()
            { return _wheels; }

            public string VehicleType()
            { return "Car"; }
        }

        /////////// Concrete Rickshaw Class ///////////
        public class Rickshaw : IVehicle
        {
            private readonly int _wheels;

            public Rickshaw()
            { _wheels = 3; }

            public int NumberOfWheels()
            { return _wheels; }

            public string VehicleType()
            { return "Rickshaw"; }
        }
    }
}
