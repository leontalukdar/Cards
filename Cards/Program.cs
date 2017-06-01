using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            CardSet cardset = new CardSet();
            Console.WriteLine(cardset);


            for(int i=0; i<11; i++)
            {
                cardset.RiffleShuffle();
            }


            HashSet<Card>[] cardSegments = cardset.GetEqualSegments(4);
            Hand[] hands = new Hand[4];

            for (int i = 0; i < 4; i++)
            {
                hands[i] = new Hand(cardSegments[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                Play.hands[i] = new Hand(cardSegments[i]);
            }



            foreach (var hand in hands)
            {
                Console.WriteLine("[ HAND ]");
                Console.WriteLine(hand);
                Console.WriteLine();
            }

            //Creating players && starting Game.
            Player[] players = new Player[4];

            players[0] = new Player("First Player");
            players[1] = new Player("Second Player");
            players[2] = new Player("Third Player");
            players[3] = new Player("Fourth Player");

            Play play = new Play(players);
            play.Start();

            Console.ReadKey();
        }

        public static void Shuffle()
        {
            CardSet cardset = new CardSet();

            for (int i = 0; i < 11; i++)
            {
                cardset.RiffleShuffle();
            }


            HashSet<Card>[] cardSegments = cardset.GetEqualSegments(4);
            Hand[] hands = new Hand[4];

            for (int i = 0; i < 4; i++)
            {
                Play.hands[i] = new Hand(cardSegments[i]);
            }
        }

    }
}
