using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while(run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            BookStore bookStore = new BookStore();

            Book book1 = new Book("Dracula", 15, 5, "Bram Stoker");
            Book book2 = new Book("Joe Speedboot", 12.5f, 3, "Tommy Wieringa");
            Magazine magazine1 = new Magazine("Time", 3.9f, 10, DayOfWeek.Friday);
            Magazine magazine2 = new Magazine("Donald Duck", 2.5f, 15, DayOfWeek.Thursday);
            CD cd1 = new CD("Seventeen Seconds", 3.9f, 5, "The Cure");

            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(cd1);

            bookStore.PrintAllItems();

            return LoopTools.LoopProgram();
        }
    }
}
