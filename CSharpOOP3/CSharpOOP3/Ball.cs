using System;
namespace CSharpOOP3
{
    public class Ball : Shape
    {
        #region Fields

        public int Radius;

        #endregion

        #region Construstors

        public Ball(string name, int radius) : base(name)
        {
            Radius = radius;
        }

        public Ball()
        {
        }

        #endregion

        #region Methods

        public override double GetVolume()
        {
            double volume = ((4.0 / 3) * Math.PI) * Math.Pow(Radius, 3);
            return volume;
        }

        public override void PrintShapeInf()
        {
            Console.WriteLine($"Ball which called {Name}, whose volume is equal to {GetVolume()}");
        }

        #endregion
    }
}

