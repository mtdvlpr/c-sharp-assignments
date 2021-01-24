using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Album :IVinylAlbum
    {
        public string Band { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public Album()
        {

        }

        public void Pause()
        {

        }

        public void Play()
        {
            Console.WriteLine($"Playing {this}");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped playing {this}'");
        }

        public override string ToString()
        {
            return $"album '{Title}, {Band} ({Year})'";
        }
    }
}
