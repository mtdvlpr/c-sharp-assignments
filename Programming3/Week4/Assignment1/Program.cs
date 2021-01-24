using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;
using Model;
using DAL;

namespace UI
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
            Book book1 = new Book(1, "Dracula", "Bram Stoker");
            Book book2 = new Book(2, "Joe Speedboot", "Tommy Wieringa");
            Book book3 = new Book(3, "The Hobbit", "J.R.R. Tolkien");

            Customer customer1 = new Customer(1, "Lionel", "Messi", "messi@gmail.com");
            Customer customer2 = new Customer(2, "Piet", "Paulusma", "paulusma@gmail.com");

            Reservation reservation1 = new Reservation(1, customer1, book1);
            Reservation reservation2 = new Reservation(1, customer1, book3);
            Reservation reservation3 = new Reservation(1, customer2, book2);
            Reservation reservation4 = new Reservation(1, customer2, book1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Books");
            Console.ResetColor();
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Customers");
            Console.ResetColor();
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reservations");
            Console.ResetColor();
            Console.WriteLine(reservation1);
            Console.WriteLine(reservation2);
            Console.WriteLine(reservation3);
            Console.WriteLine(reservation4);

            Console.WriteLine();

            CustomerDAO customerDAO = new CustomerDAO();
            foreach (Customer cust in customerDAO.GetAll())
            {
                Console.WriteLine(cust);
            }
            Customer customer = customerDAO.GetById(2);
            Console.WriteLine();
            Console.WriteLine("Searching for customer with id 2...");
            if(customer != null)
            {
                Console.WriteLine(customer);
            }
            else
            {
                Console.WriteLine("Customer not found!");
            }

            Console.WriteLine();

            BookDAO bookDAO = new BookDAO();
            foreach (Book b in bookDAO.GetAll())
            {
                Console.WriteLine($"{b.Id}. {b}");
            }
            Book book = bookDAO.GetById(2);
            Console.WriteLine();
            Console.WriteLine("Searching for book with id 2...");
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found!");
            }

            Console.WriteLine();

            ReservationDAO reservationDAO = new ReservationDAO();
            foreach (Reservation res in reservationDAO.GetAll())
            {
                Console.WriteLine(res);
            }
            List<Book> books = reservationDAO.GetAllForCustomer(customerDAO.GetById(2));
            Console.WriteLine();
            Console.WriteLine("Searching for books reserved by customer with id 2...");
            if (books.Count != 0)
            {
                foreach(Book b in books)
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("Books not found!");
            }
            List<Customer> customers = reservationDAO.GetAllForBook(bookDAO.GetById(3));
            Console.WriteLine();
            Console.WriteLine("Searching for customers who reserved book with id 3...");
            if (customers.Count != 0)
            {
                foreach (Customer cust in customers)
                {
                    Console.WriteLine(cust);
                }
            }
            else
            {
                Console.WriteLine("Customers not found!");
            }

            return ProgramTools.LoopProgram();
        }
    }
}
