using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class SolarPanelSystem : IObservable
    {
        private Random random;
        private List<IObserver> observers;

        public int Power { get; set; }

        public SolarPanelSystem()
        {

        }

        public void AddObserver()
        {

        }

        public void RemoveObserver()
        {

        }

        public void NewMeasurement()
        {

        }

        private void NotifyObservers()
        {

        }
    }
}
