using System;
namespace CSharpOOP3
{
    public class Cylinder : Shape
    {
        #region Fields

        public string Name;
        public int Height;
        public int Radius;

        #endregion

        #region Construstors

        public Cylinder(string name, int height, int radius) : base(name)
        {
            Name = name;
            Height = height;
            Radius = radius;
        }

        public Cylinder()
        {
        }

        #endregion

        #region Methods

        public override double GetVolume()
        {
            double Volume = Math.PI * (Radius * Radius) * Height;
            return Volume;
        }

        public override void PrintShapeInf()
        {
            Console.WriteLine($"Cylinder which called {Name}, whose volume is equal to {GetVolume()}");
        }

        #endregion
    }
}

