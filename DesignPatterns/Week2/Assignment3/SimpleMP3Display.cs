using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SimpleMP3Display : IObserver
    {
        private IObservable observable;

        public SimpleMP3Display(IObservable observable)
        {
            this.observable = observable;
            observable.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - '{song.Title}'");
        }
    }
}
