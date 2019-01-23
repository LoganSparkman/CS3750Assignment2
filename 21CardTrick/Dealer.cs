using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardTrick
{
    class Dealer
    {
        private int dealNumber;
        private int card;

        public void deal(int dealNumber)
        {
            this.dealNumber = dealNumber;
        }
        public void revealCard(int card)
        {
            this.card = card;
        }
        public void pickupCards(int card)
        {
            this.card = card;
        }

    }
}
