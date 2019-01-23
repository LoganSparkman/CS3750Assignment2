using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Deck
    {

        private static readonly Random getrandom = new Random();

        static public void shuffle(int[] deck)
        {
            for (int i = deck.Length - 1; i > 0; --i)
            {
                int k = getrandom.Next(i + 1);
                int temp = deck[i];
                deck[i] = deck[k];
                deck[k] = temp;
            }
        }

        public static int random21(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(1, 21);
            }
        }

    }
}
