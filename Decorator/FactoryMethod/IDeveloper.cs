using System;

// 2) Create a creator interface that introduces the factory method

namespace FactoryMethod
{
	public interface IDeveloper
	{
        public IVehicle CreateVehicle();
    }
}

