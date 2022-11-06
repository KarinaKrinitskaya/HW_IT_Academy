using System;
using System.Security.Cryptography;

namespace CSharpOOP3
{
    public struct Student
    {
        //I know about public fields in structure, but I want to practice private fields and access through property:)

        #region Fields

        private string _name;
        private int _age;

        #endregion

        #region Construstor

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
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

        public int Age
        {
            get
            {
                return _age;
            }

            set => _age = value;
        }

        #endregion

        #region Methods

        public void PrintInfAboutStudent()
        {
            Console.WriteLine($"Student: {Name}, {Age} years old.");
        }

        #endregion
    }
}
