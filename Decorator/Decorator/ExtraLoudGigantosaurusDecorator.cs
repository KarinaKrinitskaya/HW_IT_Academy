using System;

//4)We create Concrete Decorators that call the wrapped object and change its result.
namespace Decorator
{
	public class ExtraLoudGigantosaurusDecorator : BaseDecorator
	{
		public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus) : base(gigantosaurus) { }

        public override void Roar()
        {
            base.Roar();
            Console.WriteLine("THE DESEPTICONS ATTACK !!!!");
        }
    }
}

