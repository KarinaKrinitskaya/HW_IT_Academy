using System;

//4)Create a specific vehicle class with an main interface imlementation
namespace FactoryMethod
{
    internal class Truck : IVehicle
    {
        public Truck() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("I'm Truck");
        }
    }
}

