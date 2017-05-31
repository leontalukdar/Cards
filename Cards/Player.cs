using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Player
    {
        public string name { get; set; }
        private Hand hand;
        
        public Player()
        {
            name = null;
            
        }

        public Player(string name)
        {
            this.name = name;
        }
        public Hand getHand()
        {
            return this.hand;
        }

        //update after playing each card
        public void updateHand(Card card)
        {
            this.getHand().cards.Remove(card);
        }

        //set new hand after each round
        public void setNewHand(Hand hand)
        {
            this.hand = hand;
        }
    }
}
