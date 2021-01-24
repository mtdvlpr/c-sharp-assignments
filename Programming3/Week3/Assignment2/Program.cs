using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while(run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            Customer customer1 = new Customer("Lionel Messi", Convert.ToDateTime("1987/06/24"));
            Customer customer2 = new Customer("Piet Paulusma", Convert.ToDateTime("1956/02/15"));
            customer2.DateOfRegistration = Convert.ToDateTime("2017/02/20");
            
            try
            {
                PrintCustomer(customer1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            try
            {
                PrintCustomer(customer2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Ticket ticket1 = new Ticket("", 1, DateTime.ParseExact("25-02-20 18:30", "dd-MM-yy HH:mm", null), 10.5m, 0);
            Ticket ticket2 = new Ticket("Dracula", 7, DateTime.ParseExact("25-02-20 18:30", "dd-MM-yy HH:mm", null), 10.5m, 0);
            Ticket ticket3 = new Ticket("Star Wars", 1, DateTime.ParseExact("25-02-20 18:30", "dd-MM-yy HH:mm", null), 10.5m, 13);
            Ticket ticket4 = new Ticket("Dracula", 1, DateTime.ParseExact("25-02-20 18:15", "dd-MM-yy HH:mm", null), 10.5m, 0);
            Ticket ticket5 = new Ticket("Dracula", 2, DateTime.ParseExact("26-02-20 18:30", "dd-MM-yy HH:mm", null), 10.5m, 6);




            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Creating tickets");
            Console.ResetColor();

            try
            {
                PrintTicket(ticket1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                PrintTicket(ticket2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                PrintTicket(ticket3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                PrintTicket(ticket4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                PrintTicket(ticket5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Ticket ticket6 = new Ticket("Green Book", 5, DateTime.ParseExact("24-02-20 19:00", "dd-MM-yy HH:mm", null), 10.5m, 12);
            Ticket ticket7 = new Ticket("The prodigy", 3, DateTime.ParseExact("23-02-20 17:30", "dd-MM-yy HH:mm", null), 10.5m, 16);

            Console.WriteLine();
            Reservation reservation1 = new Reservation(customer1, ticket6);
            reservation1.Add(ticket7);
            reservation1.Add(ticket5);
            PrintReservation(reservation1);

            Console.WriteLine();
            Reservation reservation2 = new Reservation(customer2, ticket5);
            reservation2.Add(ticket6);
            reservation2.Add(ticket7);
            PrintReservation(reservation2);


            return ProgramTools.LoopProgram();
        }

        public void PrintCustomer(Customer customer)
        {
            if(customer.Name == null)
            {
                throw new Exception("Error occured: invalid name!");
            }
            else if (customer.DateOfBirth == DateTime.MinValue)
            {
                throw new Exception($"Error occured: invalid date of birth for {customer.Name}!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(customer.Name);
                Console.ResetColor();
                Console.WriteLine("Date of birth: " + customer.DateOfBirth.ToString("dd/MM/yyyy"));
                Console.WriteLine("Age: " + customer.Age);
                Console.WriteLine("Date of registration: " + customer.DateOfRegistration.ToString("dd/MM/yyyy"));
                Console.WriteLine("Discount: " + customer.Discount);
            }
        }

        public void PrintTicket(Ticket ticket)
        {
            if(ticket.MovieName == null)
            {
                throw new Exception("Error occured: Invalid movie name!");
            }
            else if(ticket.CinemaRoom < 1 || ticket.CinemaRoom > 5)
            {
                throw new Exception($"Error occured: Invalid cinema room ({ticket.CinemaRoom}) for movie {ticket.MovieName}!");
            }
            else if (ticket.MinimumAge != 0 && ticket.MinimumAge != 6 && ticket.MinimumAge != 9 && ticket.MinimumAge != 12 && ticket.MinimumAge != 16)
            {
                throw new Exception($"Error occured: Invalid minimum age ({ticket.MinimumAge}) for movie {ticket.MovieName}!");
            }
            else if(ticket.StartTime == DateTime.MinValue)
            {
                throw new Exception($"Error occured: Invalid start time ({ticket.StartTime}) for movie {ticket.MovieName}!");
            }
            else
            {
                Console.WriteLine("Created ticket " + ticket);
            }
        }

        public void PrintReservation(Reservation reservation)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Creating tickets for {reservation.Customer.Name}...");
            Console.ResetColor();
            foreach (Ticket ticket in reservation.Tickets)
            {
                try
                {
                    PrintTicket(ticket);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Total price of reservation: {reservation.TotalPrice.ToString("0.00")}");
        }
    }
}
