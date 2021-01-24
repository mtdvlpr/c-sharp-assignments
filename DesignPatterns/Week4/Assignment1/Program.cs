using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
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
            List<Character> characters = new List<Character>();
            characters.Add(new Queen());
            characters.Add(new Troll());
            characters.Add(new King());
            characters.Add(new Knight());
            
            foreach (Character character in characters)
            {
                character.Fight();
            }
            Console.WriteLine();
            
            // change weapon of knight to axe
            characters[3].Weapon = new AxeBehaviour();
            
            foreach (Character character in characters)
            {
                character.Fight();
            }
            Console.ReadKey();
        }
    }
}
