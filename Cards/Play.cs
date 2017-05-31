using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Play
    {
        public bool isPlaying { get; set; }
        public Player[] players = new Player[4];
        public static int roundNumber { get; set; }
        List<Card> onDeck = new List<Card>();
        public static Hand[] hands = new Hand[4];


        public Play()
        {
            this.players = null;
            isPlaying = false;
        }
        
        public Play(Player[] players)
        {
            this.players = players;
            isPlaying = true;
            roundNumber = 1;
        }

        //Game Starts Here
        public void start()
        {
            while (isPlaying)
            {
                Console.WriteLine("Round Number : {0}", roundNumber);
                setHands();
                //TODO: Determine who will play first
                for(int turns=0;turns<13;turns++)
                {
                    Card card = new Card();
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("{0}'s Hand", players[i].name);
                        Console.WriteLine(@"[ Cards ]");
                        Console.WriteLine("{0}", players[i].getHand());
                        Console.WriteLine("To play a card please enter : ");
                        Console.Write("Suit : ");
                        int x, y;
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Number : ");
                        y = int.Parse(Console.ReadLine());
                        //Console.WriteLine("{0}",_pos);
                        card = players[i].getHand().GetCard(x, y);
                        onDeck.Add(card);
                        Console.WriteLine(onDeck.ElementAt(i));
                        players[i].updateHand(card);
                    }
                    //TODO: Determine the pot winner and who will play first int next round
                    onDeck.Clear();
                }
                //TODO: Update Score of Each Player
                roundNumber++;
            }
        }

        
        //call after each round
        public void setHands()
        {
            int i = 0;
            foreach (Player player in players)
            {
                player.setNewHand(hands[i]);
                i++;
            }
        }

    }
}
