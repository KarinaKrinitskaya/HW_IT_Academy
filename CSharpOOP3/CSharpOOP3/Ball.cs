using System;
namespace CSharpOOP3
{
    public class Ball : Shape
    {
        #region Fields

        public string Name;
        public int Radius;

        #endregion

        #region Construstors

        public Ball(string name, int radius) : base(name)
        {
            Name = name;
            Radius = radius;
        }

        public Ball()
        {
        }

        #endregion

        #region Methods

        public override double GetVolume()
        {
            double Volume = ((4.0 / 3) * Math.PI) * Math.Pow(Radius, 3);
            return Volume;
        }

        public override void PrintShapeInf()
        {
            Console.WriteLine($"Ball which called {Name}, whose volume is equal to {GetVolume()}");
        }

        #endregion
    }
}

