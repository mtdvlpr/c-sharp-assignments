using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney journey;

        public TrainDisplay(ITrainJourney journey)
        {
            InitializeComponent();

            this.journey = journey;
            this.journey.AddTrainObserver(this);
            int nrOfObservers = journey.NrOfTrainObservers;
            Name = $"StationsDisplay{nrOfObservers}";
            Text = $"TrainDisplay #{nrOfObservers}";
        }

        public void Update(TrainStation currentStation)
        {
            lblCurrentStation.Text = currentStation.Name;
            lblRailwayTrack.Text = currentStation.ArrivalTrack;
        }

        private void TrainDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            journey.RemoveTrainObserver(this);
        }
    }
}
