using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class MP3Player : IObservable
    {
        public List<Song> songs;
        public List<IObserver> observers;

        public Song CurrentSong { get; private set; }

        public MP3Player()
        {
            songs = new List<Song>();

            Song song1 = new Song("Wish You Were Here", "Pink Floyd", "03:12");
            Song song2 = new Song("Dazed and Confused", "Led Zeppelin", "04:00");
            Song song3 = new Song("Billionaire", "Bruno Mars", "03:33");

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);

            CurrentSong = songs[0];
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NextSong()
        {
            int currentSongIndex = songs.IndexOf(CurrentSong);
            if (currentSongIndex == songs.Count - 1)
            {
                CurrentSong = songs[0];
            }
            else
            {
                CurrentSong = songs[currentSongIndex + 1];
            }

            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }
    }
}