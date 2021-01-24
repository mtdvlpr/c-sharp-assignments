using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Customer
    {
        private string name;
        private DateTime dateOfBirth;

        public DateTime DateOfRegistration { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (value < DateTime.Today && value > DateTime.MinValue)
                {
                    dateOfBirth = value;
                }
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - dateOfBirth.Year;
                if (DateTime.Today.DayOfYear < dateOfBirth.DayOfYear)
                {
                    age -= 1;
                }
                return age;
            }
        }

        public bool Discount
        {
            get
            {
                int years = DateTime.Today.Year - DateOfRegistration.Year;
                if (DateTime.Today.DayOfYear < DateOfRegistration.DayOfYear)
                {
                    years -= 1;
                }
                return years >= 1;
            }
        }

        public Customer (string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            DateOfRegistration = DateTime.Today;
        }
    }
}
