using System;

//3) Create a specific creators  that contain implemented factory method, ( the class must contain a method that returns a specofic object)
namespace FactoryMethod
{
	public class CarDeveloper : IDeveloper
	{
		public CarDeveloper() { }

        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}

