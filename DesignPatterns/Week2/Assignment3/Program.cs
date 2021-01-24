using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while (run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            IObservable player = new MP3Player();

            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);

            player.NextSong();
            player.NextSong();
            player.NextSong();

            return LoopTools.LoopProgram();
        }
    }
}
