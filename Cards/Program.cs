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

            foreach (var hand in hands)
            {
                Console.WriteLine("[ HAND ]");
                Console.WriteLine(hand);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
