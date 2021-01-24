using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ReservationDAO : DAO
    {
        public List<Reservation> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservations", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();
            while (reader.Read())
            {
                Reservation reservation = ReadReservation(reader);
                reservations.Add(reservation);
            }
            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        public List<Customer> GetAllForBook(Book book)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Customers.Id, FirstName, LastName, EmailAddress FROM Customers, Reservations WHERE Reservations.BookId = @BookId AND Reservations.CustomerId = Customers.Id;", dbConnection);
            cmd.Parameters.AddWithValue("@BookId", book.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            CustomerDAO customerDAO = new CustomerDAO();
            while (reader.Read())
            {
                Customer customer = ReadCustomer(reader);
                customers.Add(customer);
            }
            reader.Close();
            dbConnection.Close();

            return customers;
        }

        public List<Book> GetAllForCustomer(Customer customer)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Books.Id, Title, Author FROM Books, Reservations WHERE Reservations.CustomerId = @CustomerId AND Reservations.BookId = Books.Id;", dbConnection);
            cmd.Parameters.AddWithValue("@CustomerId", customer.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            dbConnection.Close();

            return books;
        }

        private Reservation ReadReservation(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            int customerId = (int)reader["CustomerId"];
            int bookId = (int)reader["BookId"];

            CustomerDAO customerDAO = new CustomerDAO();
            Customer customer = customerDAO.GetById(customerId);
            BookDAO bookDAO = new BookDAO();
            Book book = bookDAO.GetById(bookId);

            return new Reservation(id, customer, book);
        }

        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAdress = (string)reader["EmailAddress"];

            return new Customer(id, firstName, lastName, emailAdress);
        }

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            return new Book(id, title, author);
        }
    }
}
