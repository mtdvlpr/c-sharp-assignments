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
            Book book1 = new Book("Dracula", "Bram Stoker", 15);
            Book book2 = new Book("Joe Speedboot", "Tommy Wieringa", 12.5);
            Book book3 = new Book("The Hobbit", "J.R.R. Tolkien", 12.5);
            Magazine magazine1 = new Magazine("Time", DayOfWeek.Friday, 3.9);
            Magazine magazine2 = new Magazine("Donald Duck", DayOfWeek.Thursday, 2.5);
            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(book3);
            bookStore.PrintCompleteStock();

            return ProgramTools.LoopProgram();
        }
    }
}
