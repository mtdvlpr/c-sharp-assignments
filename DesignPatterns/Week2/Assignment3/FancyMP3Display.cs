using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class FancyMP3Display: IObserver
    {
        private IObservable observable;

        public FancyMP3Display(IObservable observable)
        {
            this.observable = observable;
            observable.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: '{song.Title}' by {song.Artist} ({song.Duration})");
        }
    }
}
