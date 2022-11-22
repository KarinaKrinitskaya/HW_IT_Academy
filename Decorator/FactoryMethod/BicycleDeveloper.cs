using System;

//3) Create a specific creators  that contain implemented factory method
namespace FactoryMethod
{
	public class BicycleDeveloper : IDeveloper
	{
		public BicycleDeveloper() { }

		public IVehicle CreateVehicle()
        {
            return new Bicycle();
        }
    }
}

