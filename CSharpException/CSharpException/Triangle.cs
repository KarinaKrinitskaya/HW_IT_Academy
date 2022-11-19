using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace CSharpException
{
    public class Triangle
    {
        #region Fields

        private int count;
        private double side_A;
        private double side_B;
        private double side_C;

        #endregion

        #region Property

        public double Side_A
        {
            set => side_A = value;
            get => side_A;
        }

        public double Side_B
        {
            set => side_B = value;
            get => side_B;
        }

        public double Side_C
        {
            set => side_C = value;
            get => side_C;
        }

        public bool IsFilled
        {
            get => count == 3;
        }

        #endregion

        #region Construstor

        public Triangle()
        {
        }

        public Triangle(double side_1, double side_2, double side_3)
        {
            side_A = side_1;
            side_B = side_2;
            side_C = side_3;
        }

        #endregion

        #region Methods

        public void InputSide()
        {
            Console.WriteLine("Enter the size your shape:");
            string val = Console.ReadLine();
            bool result = double.TryParse(val, out var n);

            if (!result || n <= 0)
            {
                throw new InvalidSideException("Incorrect value. The side of the shape is 0, negative or not number. Try again. ");
            }
            else
            {
                if (count == 0)
                    Side_A = n;
                else if (count == 1)
                    Side_B = n;
                else
                    Side_C = n;
                count++;
            }
        }

        public void ValidateSides()
        {
            if (side_A > side_B + side_C || side_B > side_A + side_C || side_C > side_A + side_B)
            {
                throw new InvalidTriangleExeption("One side of a shape is less than the sum of the other two sides.");
            }
        }

        #endregion
    }
}

