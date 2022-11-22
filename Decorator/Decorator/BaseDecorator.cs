using System;

//3)Сreate a Base Decorator class. The main purpose of this class is to define a wrapper interface for all concrete decorators.
namespace Decorator
{
    public abstract class BaseDecorator : IGigantosaurus
    {
        protected IGigantosaurus _gigantosaurus;

        public BaseDecorator(IGigantosaurus gigantosaurus)
        {
            this._gigantosaurus = gigantosaurus;
        }

        //Delegate all work to wrapped component
        public virtual void Roar()
        {
            _gigantosaurus.Roar();
        }
    }
}

