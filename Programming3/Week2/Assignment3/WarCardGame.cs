using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();
            for (int i = 0; i < deck.allPlayingCards.Count; i++)
            {
                player1.AddCard(deck.allPlayingCards[i]);
                i++;
                player2.AddCard(deck.allPlayingCards[i]);
            }
        }

        public bool EndOfGame()
        {
            return (player1.cards.Count == 0 || player2.cards.Count == 0);
        }

        public void NextCard()
        {
            int player1Count = player1.cards.Count;
            int player2Count = player2.cards.Count;

            PlayingCard card1 = player1.GetNextCard();
            PlayingCard card2 = player2.GetNextCard();

            Console.WriteLine($"[{player1.name} ({player1Count}x)] {card1} - [{player2.name} ({player2Count}x)] {card2}");

            if(card1.rank > card2.rank)
            {
                player1.AddCard(card2);
                player1.AddCard(card1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player1.name + " got the cards");
                Console.ResetColor();
            }
            else if(card2.rank > card1.rank)
            {
                player2.AddCard(card1);
                player2.AddCard(card2);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(player2.name + " got the cards");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"Cards left: [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
                Console.ResetColor();
            }
        }
    }
}
