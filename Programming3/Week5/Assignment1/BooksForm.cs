using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using LogicLayer;

namespace UI
{
    public partial class BooksForm : Form
    {
        private BookService bookService = new BookService();
        private ReservationService reservationService = new ReservationService();

        public BooksForm()
        {
            InitializeComponent();
            DisplayBooks();
        }

        private void DisplayBooks()
        {
            List<Book> books = bookService.GetAll();
            foreach (Book book in books)
            {

                cmbBooks.Items.Add(book);
            }
            cmbBooks.SelectedIndex = 0;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> customers = reservationService.GetAllForBook((Book)cmbBooks.SelectedItem);
            lstReservations.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstReservations.Items.Add(customer);
            }
        }
    }
}
