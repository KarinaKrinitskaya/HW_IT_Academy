using System;

//2)Create a concrete components to provide implementations of the default behavior.
namespace Decorator
{
	public class Gigantosaurus : IGigantosaurus
	{
		public Gigantosaurus() { }

        public void Roar()
        {
            Console.WriteLine("Rrrrr!");
        }
    }
}

