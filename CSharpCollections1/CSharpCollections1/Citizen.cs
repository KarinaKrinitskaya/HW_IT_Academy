using System;
using System.Xml.Linq;

namespace CSharpCollections1
{
    public class Citizen : IComparable<Citizen>
    {
        #region Fields

        private string name;
        private string lastName;
        private string patronymic;

        private string street;
        private string house;

        private DateTime birthDate;

        #endregion

        #region Construstors

        public Citizen(string name, string lastName, string patronymic, string street, string house, DateTime dateofBorn)
        {
            this.name = name;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.street = street;
            this.house = house;
            this.birthDate = dateofBorn;
        }

        #endregion

        #region Property

        public string Name
        {
            get
            {
                return name;
            }

            set => name = value;
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set => lastName = value;
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set => patronymic = value;
        }

        public string Street
        {
            get
            {
                return street;
            }

            set => street = value;
        }

        public string House
        {
            get
            {
                return house;
            }

            set => house = value;
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set => birthDate = value;
        }

        #endregion

        #region Methods

        public bool CanVote()
        {
            int legalAge = 18;
            return GetAge() > legalAge ? true : false;
        }

        public int CompareTo(Citizen? other)
        {
            var lastNameCmp = lastName.CompareTo(other.lastName);
            if (lastNameCmp != 0)
            {
                return lastNameCmp;
            }
            else
            {
                return name.CompareTo(other.name);
            }
        }

        public int GetAge()
        {
            TimeSpan age = DateTime.Today - birthDate;
            return (int)(age.TotalDays / 365);
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Citizen: {Name}, {LastName}, {Patronymic}, Adress: {Street} - {House}, Date of birth: {BirthDate}.";
        }

        #endregion
    }
}

