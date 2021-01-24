using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace LogicLayer
{
    public class ReservationService
    {
        private ReservationDAO reservationDAO = new ReservationDAO();

        public List<Reservation> GetAll()
        {
            return reservationDAO.GetAll();
        }

        public List<Book> GetAllForCustomer(Customer customer)
        {
            return reservationDAO.GetAllForCustomer(customer);
        }

        public List<Customer> GetAllForBook(Book book)
        {
            return reservationDAO.GetAllForBook(book);
        }
    }
}
