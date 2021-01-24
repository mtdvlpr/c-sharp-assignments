using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Ticket
    {
        string movieName;
        int cinemaRoom;
        DateTime startTime;
        decimal price;
        int minimumAge;

        public string MovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                if(value != "")
                {
                    movieName = value;
                }
            }
        }

        public int CinemaRoom
        {
            get
            {
                return cinemaRoom;
            }
            set
            {
                if(value >= 1 && value <= 5)
                {
                    cinemaRoom = value;
                }
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                if ((value.Minute == 0 || value.Minute == 30) && value.Second == 0)
                {
                    startTime = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public int MinimumAge
        {
            get
            {
                return minimumAge;
            }
            set
            {
                if(value == 0 || value  == 6 || value == 9 || value == 12 || value == 16)
                {
                    minimumAge = value;
                }
                else
                {
                    minimumAge = value;
                }
            }
        }

        public bool Discount
        {
            get
            {
                return (StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Tuesday);
            }
        }

        public Ticket(string name, int room, DateTime startTime, decimal price, int age)
        {
            this.MovieName = name;
            this.CinemaRoom = room;
            this.StartTime = startTime;
            this.Price = price;
            this.MinimumAge = age;
        }

        public override string ToString()
        {
            return $"'{MovieName}', starttime: {StartTime}, price: {Price}, room: {CinemaRoom} ({MinimumAge}+)";
        }
    }
}
