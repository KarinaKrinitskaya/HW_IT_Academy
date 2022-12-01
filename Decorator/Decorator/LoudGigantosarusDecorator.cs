using System;

//4)We create Concrete Decorators that call the wrapped object and change its result.
namespace Decorator
{
	public class LoudGigantosarusDecorator: BaseDecorator
	{
		public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus) : base(gigantosaurus) { }

		override public void Roar()
		{
			base.Roar();
			Console.WriteLine("RRRRRRRRRRRAWW!!!!");
		}
	}
}

