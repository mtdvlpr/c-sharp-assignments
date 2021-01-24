using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace LogicLayer
{
    public class BookService
    {
        private BookDAO bookDAO = new BookDAO();

        public List<Book> GetAll()
        {
            return bookDAO.GetAll();
        }

        public Book GetById(int id)
        {
            return bookDAO.GetById(id);
        }
    }
}
