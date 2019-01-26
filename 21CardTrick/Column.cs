using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Column
    {
        public Card[] cards = new Card[7];

        int totalCards = 0;

        public void addCard(Card card)
        {
            cards[totalCards] = card;
            totalCards++;
        }
    }
}
