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
        public Hand GetHand()
        {
            return this.hand;
        }

        //update after playing each card
        public void UpdateHand(Card card)
        {
            this.GetHand().UpdatePlayerCards(card);
        }

        //set new hand after each round
        public void SetNewHand(Hand hand)
        {
            this.hand = hand;
        }
    }
}
