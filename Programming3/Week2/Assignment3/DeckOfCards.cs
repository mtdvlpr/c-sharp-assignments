using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards;

        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();
            InitCards();
        }

        private void InitCards()
        {
            // All cards of Clubs
            for (uint rank = 2; rank <= 14; rank++)
            {
                PlayingCard playingCard = new PlayingCard(rank, CardSuit.Clubs);
                allPlayingCards.Add(playingCard);
            }
            // All cards of Diamonds
            for (uint rank = 2; rank <= 14; rank++)
            {
                PlayingCard playingCard = new PlayingCard(rank, CardSuit.Diamonds);
                allPlayingCards.Add(playingCard);
            }
            // All cards of Hearts
            for (uint rank = 2; rank <= 14; rank++)
            {
                PlayingCard playingCard = new PlayingCard(rank, CardSuit.Hearts);
                allPlayingCards.Add(playingCard);
            }
            // All cards of Spades
            for (uint rank = 2; rank <= 14; rank++)
            {
                PlayingCard playingCard = new PlayingCard(rank, CardSuit.Spades);
                allPlayingCards.Add(playingCard);
            }
        }

        public void Print()
        {
            foreach (PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card);
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int n = allPlayingCards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                PlayingCard randomCard = allPlayingCards[k];
                allPlayingCards[k] = allPlayingCards[n];
                allPlayingCards[n] = randomCard;
            }
        }
    }
}
