using System;
using System.Collections.Generic;

namespace cardGameSix
{
    /**
     * Each player hand will hold x cards
     */
    class PlayerHand
    {

        List<Card> cards = new List<Card>();
        

        public Card ExtractCard(int pos)
        {
            if (cards[pos] == null)
            {
                throw new Exception("not possible");
            }
            Card card = cards[pos];
            cards.RemoveAt(pos);
            return card;
        }


        public void InsertCard(int pos, Card card)
        {
            if (cards[pos] != null)
            {
                throw new Exception("not possible");
            }
            cards[pos] = card;
        }


        public static PlayerHand FillHand(Deck deck, int nrCards)
        {
            if (deck.getCard().Count < nrCards)
            {
                throw new Exception("not possible");
            }
            PlayerHand playerHand = new PlayerHand();

            for (int count = 0; count < nrCards; count++)
            {
                playerHand.GetCards().Add(deck.Pop());
            }
            return playerHand;
        }

        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.Write(card + " ");
            }
            Console.WriteLine();
        }


        public List<Card> GetCards()
        {
            return cards;
        }

        
    }




}