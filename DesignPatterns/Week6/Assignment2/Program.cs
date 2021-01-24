using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory expensiveFactory = new HighBudgetFactory();
            ComputerShop shop1 = new ComputerShop(expensiveFactory);
            shop1.AssembleMachine();
            
            Console.WriteLine();
            
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory cheapFactory = new LowBudgetFactory();
            ComputerShop shop2 = new ComputerShop(cheapFactory);
            shop2.AssembleMachine();
            
            Console.ReadKey();

        }
    }
}
