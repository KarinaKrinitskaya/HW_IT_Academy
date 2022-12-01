using System;

//3) Create a specific creators  that contain implemented factory method
namespace FactoryMethod
{
	public class UnicycleDeveloper : IDeveloper
	{
        public IVehicle CreateVehicle()
        {
            return new Unicycle();
        }
    }
}

