using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Reservation
    {
        public Customer Customer { get; set; }

        public List<Ticket> Tickets { get; set; }

        public double TotalPrice
        {
            get
            {
                double totalprice = 0;
                foreach (Ticket ticket in Tickets)
                {
                    if(Customer.Age >= ticket.MinimumAge)
                    {
                        if(ticket.StartTime.DayOfWeek == DayOfWeek.Monday || ticket.StartTime.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            totalprice += (double)ticket.Price * .95;
                        }
                        else
                        {
                            totalprice += (double)ticket.Price;
                        }
                    }
                    
                }
                if(Customer.Discount)
                {
                    totalprice *= .9;
                }
                return totalprice;
            }
        }

        public Reservation(Customer customer, Ticket ticket)
        {
            this.Customer = customer;
            Tickets = new List<Ticket>();
            Tickets.Add(ticket);
        }

        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
