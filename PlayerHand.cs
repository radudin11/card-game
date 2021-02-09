using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    class PlayerHand
    {
        //public static Card nullCard = new Card(0, 0);
        List<Card> playerHand = new List<Card>();
        
       
        
        public void Insert(int pos, Card card)
        {
            playerHand[pos] = card;
        }

        public void Fill(Deck deck)
        {
            for(int count = 0; count < 4; count++)
            {
                playerHand.Add(deck.Pop());
            }
        }

        public Card Extract(int pos)
        {
            Card card = playerHand[pos];
            playerHand.RemoveAt(pos);
            return card;

        }

        public void Print()
        {
            foreach(Card card in playerHand)
            {
                Console.Write(card+" ");
            }
            Console.WriteLine();
        }
    }
}
