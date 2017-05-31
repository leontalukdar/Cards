using System;
using System.Collections.Generic;




namespace Cards
{
    public class Card : IComparer<Card>
    {
        public int suit { get; set; }
        public int number { get; set; }

        public Card(int suit = -1, int number = -1)
        {
            this.suit = suit;
            this.number = number;
        }

        public string actualSuit
        {
            get
            {
                if (suit >= 0 && suit < CardInfo.suits.Length)
                {
                    return CardInfo.suits[suit];
                }
                else
                {
                    return "None";
                }
            }
        }

        public string actualNumber
        {
            get
            {
                if (number >= 0 && number < CardInfo.numbers.Length)
                {
                    return CardInfo.numbers[number];
                }
                else
                {
                    return "None";
                }
            }
        }

        public override string ToString()
        {
            string suit = actualSuit;
            string number = actualNumber;
            return string.Format("{0} of {1}", actualNumber, actualSuit);
        }

        public int Compare(Card a, Card b)
        {
            if(a.suit < b.suit)
            {
                return 1;
            }
            else if(a.suit == b.suit)
            {
                if(a.number > b.number)
                {
                    return 1;
                }
                else if(a.number == b.number)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }





}