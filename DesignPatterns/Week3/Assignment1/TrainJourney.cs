using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TrainJourney : ITrainJourney
    {
        private List<TrainStation> stations;
        private List<ITrainDisplay> trainObservers;
        private List<IStationsDisplay> stationsObservers;

        private int currentStation;

        public int NrOfTrainObservers { get; set; }

        public int NrOfStationsObservers { get; set; }

        public TrainJourney()
        {
            trainObservers = new List<ITrainDisplay>();
            stationsObservers = new List<IStationsDisplay>();
            stations = new List<TrainStation>()
            {
                new TrainStation("Alkmaar", "4", DateTime.Parse("04/20/2020 16:19"), DateTime.Parse("04/20/2020 16:19")),
                new TrainStation("Heiloo", "2", DateTime.Parse("04/20/2020 16:24"), DateTime.Parse("04/20/2020 16:24")),
                new TrainStation("Castricum", "2", DateTime.Parse("04/20/2020 16:29"), DateTime.Parse("04/20/2020 16:29")),
                new TrainStation("Uitgeest", "4b", DateTime.Parse("04/20/2020 16:34"), DateTime.Parse("04/20/2020 16:35")),
                new TrainStation("Heemskerk", "1", DateTime.Parse("04/20/2020 16:39"), DateTime.Parse("04/20/2020 16:39")),
                new TrainStation("Beverwijk", "3", DateTime.Parse("04/20/2020 16:42"), DateTime.Parse("04/20/2020 16:42")),
                new TrainStation("Driehuis", "2", DateTime.Parse("04/20/2020 16:47"), DateTime.Parse("04/20/2020 16:47")),
                new TrainStation("Santpoort Noord", "3", DateTime.Parse("04/20/2020 16:50"), DateTime.Parse("04/20/2020 16:50")),
                new TrainStation("Santpoort Zuid", "1", DateTime.Parse("04/20/2020 16:53"), DateTime.Parse("04/20/2020 16:53")),
                new TrainStation("Bloemendaal", "1", DateTime.Parse("04/20/2020 16:56"), DateTime.Parse("04/20/2020 16:56")),
                new TrainStation("Haarlem", "3", DateTime.Parse("04/20/2020 17:00"), DateTime.Parse("04/20/2020 17:00"))
            };
            currentStation = 0;
            NrOfTrainObservers = 0;
            NrOfStationsObservers = 0;
        }

        public void NextStation()
        {
            if(currentStation != stations.Count - 1)
            {
                currentStation++;
            }
            else
            {
                currentStation = 0;
            }
            NotifyObservers();
        }

        public void AddTrainObserver(ITrainDisplay observer)
        {
            trainObservers.Add(observer);
            observer.Update(stations[currentStation]);
            NrOfTrainObservers++;
        }

        public void RemoveTrainObserver(ITrainDisplay observer)
        {
            trainObservers.Remove(observer);
        }

        public void AddStationsObserver(IStationsDisplay observer)
        {
            stationsObservers.Add(observer);
            NotifyStationsObserver(observer);
            NrOfStationsObservers++;
        }

        public void RemoveStationsObserver(IStationsDisplay observer)
        {
            stationsObservers.Remove(observer);
        }

        private void NotifyObservers()
        {
            NotifyTrainObservers();

            foreach (IStationsDisplay observer in stationsObservers)
            {
                NotifyStationsObserver(observer);
            }
        }

        private void NotifyTrainObservers()
        {
            foreach (ITrainDisplay observer in trainObservers)
            {
                observer.Update(stations[currentStation]);
            }
        }

        private void NotifyStationsObserver(IStationsDisplay observer)
        {
            List<TrainStation> remainingStations = new List<TrainStation>();
            for (int i = currentStation + 1; i < stations.Count; i++)
            {
                remainingStations.Add(stations[i]);
            }
            observer.Update(remainingStations);
        }
    }
}
