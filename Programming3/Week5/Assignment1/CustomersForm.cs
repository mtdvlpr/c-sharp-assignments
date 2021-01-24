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
    public partial class CustomersForm : Form
    {
        private CustomerService customerService = new CustomerService();
        private ReservationService reservationService = new ReservationService();

        public CustomersForm()
        {
            InitializeComponent();
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            List<Customer> customers = customerService.GetAll();
            foreach (Customer customer in customers)
            {
                
                cmbCustomers.Items.Add(customer);
            }
            cmbCustomers.SelectedIndex = 0;
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Book> books = reservationService.GetAllForCustomer((Customer)cmbCustomers.SelectedItem);
            lstReservations.Items.Clear();
            foreach(Book book in books)
            {
                lstReservations.Items.Add(book);
            }
        }
    }
}
