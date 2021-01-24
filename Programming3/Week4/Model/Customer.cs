using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        int id;

        public int Id { get { return id; } set { id = value; } }

        public string EmailAdress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = emailAddress;
        }

        public override string ToString()
        {
            return $"{FullName} ({EmailAdress})";
        }
    }
}
