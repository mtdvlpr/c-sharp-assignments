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
    public partial class ReservationsForm : Form
    {
        private ReservationService reservationService = new ReservationService();

        public ReservationsForm()
        {
            InitializeComponent();
            DisplayReservations();
        }

        private void DisplayReservations()
        {
            List<Reservation> reservations = reservationService.GetAll();
            listViewReservations.Clear();
            listViewReservations.Columns.Add("Id", 30);
            listViewReservations.Columns.Add("Customer", 100);
            listViewReservations.Columns.Add("Book", -2);
            foreach (Reservation reservation in reservations)
            {
                ListViewItem item = new ListViewItem(reservation.Id.ToString());
                item.SubItems.Add(reservation.Customer.ToString());
                item.SubItems.Add(reservation.Book.ToString());
                item.Tag = reservation;
                listViewReservations.Items.Add(item);
            }
        }
    }
}
