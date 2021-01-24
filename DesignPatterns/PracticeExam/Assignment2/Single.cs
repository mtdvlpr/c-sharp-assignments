using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Single : IVinylSingle
    {
        public string Artist { get; set; }

        public int Ranking { get; set; }

        public string Title { get; set; }

        public Single()
        {

        }

        public void Pause()
        {

        }

        public void Play()
        {
            Console.WriteLine($"Playing single '{this} ({Ranking})'");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped playing single '{this} ({Ranking})'");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
