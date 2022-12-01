using FactoryMethod;

IVehicle someVehicle001;
someVehicle001 = new UnicycleDeveloper().CreateVehicle();
someVehicle001.PrintVehicleInfo();

IVehicle someVehicle002;
someVehicle002 = new BicycleDeveloper().CreateVehicle();
someVehicle002.PrintVehicleInfo();

IVehicle someVehicle003;
someVehicle003 = new CarDeveloper().CreateVehicle();
someVehicle003.PrintVehicleInfo();

IVehicle someVehicle004;
someVehicle004 = new TruckDeveloper().CreateVehicle();
someVehicle004.PrintVehicleInfo();

Console.ReadLine();