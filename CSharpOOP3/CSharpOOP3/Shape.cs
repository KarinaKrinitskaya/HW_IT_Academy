using System;

namespace CSharpOOP3
{
    public abstract class Shape
    {
        #region Fields

        private string _name;

        #endregion

        #region Construstors

        public Shape(string name)
        {
            _name = name;
        }

        public Shape()
        {
        }

        #endregion

        #region Property

        public string Name
        {
            get
            {
                return _name;
            }

            set => _name = value;
        }

        #endregion

        #region Methods

        public abstract double GetVolume();

        public virtual void PrintShapeInf()
        {
            Console.WriteLine("");
        }

        #endregion

    }
}
