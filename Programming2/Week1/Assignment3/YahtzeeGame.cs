using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class YahtzeeGame
    {
        public Dice[] dices = new Dice[5];

        public void Init()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice();
            }
        }

        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }

        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            for (int i = 1; i < dices.Length; i++)
            {
                if (dices[0].value != dices[i].value)
                {
                    return false;
                }
            }
            return true;
        }

        public int XOfAKind(int x)
        {
            int[] throws = new int[6];

            for (int i = 0; i < throws.Length; i++)
            {
                throws[i] = 0;
            }

            for (int i = 0; i < dices.Length; i++)
            {
                throws[dices[i].value - 1] += 1;
            }

            for (int i = 0; i < throws.Length; i++)
            {
                if (throws[i] == x)
                {
                    return throws[i];
                }
            }
            return 0;
        }

        public bool ThreeOfAKind()
        {
            if(XOfAKind(3) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FourOfAKind()
        {
            if (XOfAKind(4) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FullHouse()
        {
            if (XOfAKind(3) > 0 && XOfAKind(2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SmallStraight()
        {
            int counter = 1;
            dices = SortArray(dices);

            for (int i = 1; i < dices.Length; i++)
            {
                if(dices[i].value == dices[i-1].value + 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
            }
            if(counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BigStraight()
        {
            int counter = 1;
            dices = SortArray(dices);

            for (int i = 1; i < dices.Length; i++)
            {
                if (dices[i].value == dices[i - 1].value + 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
            }
            if (counter == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dice[] SortArray(Dice[] dices)
        {
            int[] sorted = new int[5];
            for (int i = 0; i < dices.Length; i++)
            {
                sorted[i] = dices[i].value;
            }
            Array.Sort(sorted);

            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].value = sorted[i];
            }
            return dices;
        }
    }
}
