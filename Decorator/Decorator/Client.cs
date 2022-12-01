using System;
using System.ComponentModel;

//5)We create a Client code that works with all objects using the Component interface.
//Thus, it remains independent of the specific component classes it works with.
namespace Decorator
{
	public class Client
	{
		public Client() { }

		public void ClientCode(IGigantosaurus gigantosaurus)
		{
			Console.WriteLine($"MY RESULT:");
			gigantosaurus.Roar();
		}
	}
}

