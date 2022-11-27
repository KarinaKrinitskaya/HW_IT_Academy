using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace CSharpAdvanced
{
    public class Flower
    {
        #region Fields

        private string name;
        private string color;
        private double price;

        #endregion

        #region Constructors

        public Flower() { }

        public Flower(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price= price;
        }

        #endregion

        #region Properties

        public string Name
        {
            get => name;

            set => name = value;
        }

        public string Color
        {
            get => color;

            set => color = value;
        }

        public double Price
        {
            get => price;

            set => price = value;
        }

        #endregion

        #region Methods

        public void PrintInfo()
        {
            Console.WriteLine($"\nMy name is {name}, color is {color} and price is {price}");
        }

        #endregion
    }
}

