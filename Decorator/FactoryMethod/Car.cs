using System;

//4)Create a specific vehicle class with an main interface imlementation
namespace FactoryMethod
{
    internal class Car : IVehicle
	{
		public Car() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("I'm CAR");
        }
    }
}

