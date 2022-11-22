using System;

//4)Create a specific vehicle class with an main interface imlementation
namespace FactoryMethod
{
    internal class Unicycle : IVehicle
	{
		public Unicycle() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("I'm Unicycle");
        }
    }
}

