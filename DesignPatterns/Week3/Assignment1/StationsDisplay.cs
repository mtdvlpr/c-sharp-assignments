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
    public partial class StationsDisplay : Form, IStationsDisplay
    {
        private ITrainJourney journey;

        public StationsDisplay(ITrainJourney journey)
        {
            InitializeComponent();

            this.journey = journey;
            this.journey.AddStationsObserver(this);
            int nrOfObservers = journey.NrOfStationsObservers;
            Name = $"StationsDisplay{nrOfObservers}";
            Text = $"StationsDisplay #{nrOfObservers}";
        }

        public void Update(List<TrainStation> remainingStations)
        {
            lblRemainingStations.Text = "";
            foreach (TrainStation station in remainingStations)
            {
                string stationInformation = $"{station.Name} ({station.ArrivalTrack}) - {station.ArrivalTime:HH:mm}\n\n";
                lblRemainingStations.Text += stationInformation;
            }
        }

        private void StationsDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            journey.RemoveStationsObserver(this);
        }
    }
}
