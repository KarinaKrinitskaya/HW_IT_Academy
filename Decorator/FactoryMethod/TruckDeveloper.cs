using System;

//3) Create a specific creators  that contain implemented factory method
namespace FactoryMethod
{
	public class TruckDeveloper : IDeveloper
	{
		public TruckDeveloper() { }

        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}

