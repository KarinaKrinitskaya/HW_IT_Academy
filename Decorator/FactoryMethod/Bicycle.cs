using System;

//4)Create a specific vehicle class with an main interface imlementation
namespace FactoryMethod
{
	internal class Bicycle : IVehicle
	{
		public Bicycle() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("I'm Bicycle");
        }
    }
}

