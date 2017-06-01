using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    public class Hand
    {
        private HashSet<Card> cards = new HashSet<Card>();


        public Hand() { }

        public Hand(Card[] cards)
        {
            foreach(Card card in cards)
            {
                this.cards.Add(card);
            }
        }

        public Hand(HashSet<Card> cards)
        {
            foreach (Card card in cards)
            {
                this.cards.Add(card);
            }
        }


        public bool Contains(int suit, int number)
        {
            foreach(Card card in cards)
            {
                if(card.suit == suit && card.number == number)
                {
                    return true;
                }
            }

            return false;
        }

        public Card GetCard(int suit, int number)
        {
            foreach(Card card in cards)
            {
                if(card.suit == suit && card.number == number)
                {
                    return card;
                }
            }

            return null;
        }

        HashSet<Card> GetCardsOfSuit(int suit)
        {
            HashSet<Card> cardsOfSuit = new HashSet<Card>();

            foreach(Card card in cards)
            {
                if(card.suit == suit)
                {
                    cardsOfSuit.Add(card);
                }
            }

            return cardsOfSuit;
        }
        
        public void Sort()
        {
            //var sortedCards = cards.Sort();
        }


        public override string ToString()
        {
            string str = "";

            foreach(var card in cards)
            {
                str += card + "\n";
            }

            return str;
        }

        public void UpdatePlayerCards(Card card)
        {
            cards.Remove(card);
        }
    }
}