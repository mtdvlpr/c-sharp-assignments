using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
            Dice d1 = new Dice();

            for (int i = 0; i < 10; i++)
            {
                d1.Throw();
                d1.DisplayValue();
                Console.Write(" ");
            }
            Console.WriteLine();

            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();

            yahtzeeGame.Throw();
            yahtzeeGame.DisplayValues();

            yahtzeeGame.Throw();
            yahtzeeGame.DisplayValues();

            Console.WriteLine();

            PlayYahtzee(yahtzeeGame);

            EndProgram();
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int stop = 0;
            int timer = 0;
            int BigStraight = 9999;
            int SmallStraight = 9999;
            int FourOfAKind = 9999;
            int ThreeOfAKind = 9999;
            int FullHouse = 9999;
            int Yahtzee = 9999;
            do
            {
                game.Throw();
                Console.Write("{0,3}. ", timer+1);
                game.DisplayValues();
                timer++;
                if (game.ThreeOfAKind() && timer < ThreeOfAKind)
                {
                    ThreeOfAKind = timer;
                }
                if (game.FourOfAKind() && timer < FourOfAKind)
                {
                    FourOfAKind = timer;
                }
                if (game.Yahtzee() && timer < Yahtzee)
                {
                    Yahtzee = timer;
                }
                if (game.FullHouse() && timer < FullHouse)
                {
                    FullHouse = timer;
                }
                if (game.BigStraight() && timer < BigStraight)
                {
                    BigStraight = timer;
                }
                if (game.SmallStraight() && timer < SmallStraight)
                {
                    SmallStraight = timer;
                }
                if (ThreeOfAKind < 9999 && FourOfAKind < 9999 && Yahtzee < 9999 && BigStraight < 9999 && FullHouse < 9999 && SmallStraight < 9999)
                {
                    stop = 1;
                }

            } while (stop == 0);
            Console.WriteLine("Number of attempts needed (Three of a kind): {0}", ThreeOfAKind);
            Console.WriteLine("Number of attempts needed (Four of a kind): {0}", FourOfAKind);
            Console.WriteLine("Number of attempts needed (Full house): {0}", FullHouse);
            Console.WriteLine("Number of attempts needed (Small straight): {0}", SmallStraight);
            Console.WriteLine("Number of attempts needed (Big straight): {0}", BigStraight);
            Console.WriteLine("Number of attempts needed (Yahtzee): {0}", Yahtzee);
        }

        void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}
