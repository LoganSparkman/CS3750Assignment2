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
        private Deck deck = new Deck();
        private Card[] cards = new Card[21];
        private Board board = new Board();
        private Player player = new Player();
        public void deal()
        {
            if (!player.getHasSelectedCard())
            {
                deck.shuffle();
                cards = deck.random21();
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.addToColumn(j, cards[i * 3 + j]);
                }
            }
        }
        public Card revealCard(int card)
        {
            return cards[10];
        }
        public void pickupCards(int card)
        {
            Card[] firstColumn = board.columns[0].cards;
            Card[] secondColumn = board.columns[1].cards;
            Card[] thirdColumn = board.columns[2].cards;
            if (player.getColumn() == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    cards[i] = secondColumn[i];
                    cards[i + 7] = firstColumn[i];
                    cards[i + 14] = thirdColumn[i];
                }
            }
            else if (player.getColumn() == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    cards[i] = firstColumn[i];
                    cards[i + 7] = secondColumn[i];
                    cards[i + 14] = thirdColumn[i];
                }
            }
            else if (player.getColumn() == 2)
            {
                for (int i = 0; i < 7; i++)
                {
                    cards[i] = firstColumn[i];
                    cards[i + 7] = thirdColumn[i];
                    cards[i + 14] = secondColumn[i];
                }
            }
        }

    }
}
