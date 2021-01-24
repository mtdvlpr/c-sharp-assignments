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
    public class BookDAO : DAO
    {
        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
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

        public Book GetById(int bookId)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Id = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", bookId);
            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;
            while (reader.Read())
            {
                book = ReadBook(reader);
            }
            reader.Close();
            dbConnection.Close();

            return book;
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
