using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles { get; set; }

        public IVinylSingle CurrentSingle { get; set; }

        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;
            CurrentSingle = Singles[0];
        }

        public void Play()
        {
            CurrentSingle.Play();
        }

        public void SelectSingle(int index)
        {
            CurrentSingle = Singles[index];
        }

        public void Stop()
        {
            CurrentSingle.Stop();
        }
    }
}
