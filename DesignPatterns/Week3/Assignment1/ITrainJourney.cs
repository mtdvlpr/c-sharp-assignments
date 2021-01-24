using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface ITrainJourney
    {
        void NextStation();

        int NrOfTrainObservers { get; }

        int NrOfStationsObservers { get; }

        void AddTrainObserver(ITrainDisplay observer);

        void RemoveTrainObserver(ITrainDisplay observer);

        void AddStationsObserver(IStationsDisplay observer);

        void RemoveStationsObserver(IStationsDisplay observer);
    }
}
