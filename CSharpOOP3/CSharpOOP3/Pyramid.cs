using System;
using System.Xml.Linq;

namespace CSharpOOP3
{
    public class Pyramid : Shape
    {
        #region Fields

        public int Height;
        public double Square;

        #endregion

        #region Construstors

        public Pyramid(string name, int height, double square) : base(name)
        {
            Height = height;
            Square = square;
        }

        public Pyramid()
        {
        }

        #endregion

        #region Methods

        public override double GetVolume()
        {
            double volume = ((1.0 / 3) * Square) * Height;
            return volume;
        }

        public override void PrintShapeInf()
        {
            Console.WriteLine($"Pyramid which called {Name}, whose volume is equal to {GetVolume()}");
        }

        #endregion
    }
}

