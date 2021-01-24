using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        int id;

        public int Id { get { return id; } set { id = value; } }

        Book book;

        public Book Book { get { return book; } set { book = value; } }

        Customer customer;

        public Customer Customer { get { return customer; } set { customer = value; } }

        public DateTime ReservationDateTime { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
            ReservationDateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{customer.FullName} has reserved {book} at {ReservationDateTime}";
        }
    }
}
