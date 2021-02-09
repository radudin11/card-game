using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGameSix
{

    /**
     * Deck class represents pile of all posible cards based onb Suite and Values
     */
    public class Deck
    {
        Stack<Card> deck = new Stack<Card>();

        //Deck shuffle. 
        public void Shuffle()
        {
            var rnd = new Random();
            var values = deck.ToArray();
            deck.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
                deck.Push(value);
        }

        public void Print()
        {
            foreach (Card card in deck)
            {
                Console.Write(card + " ");
            }
        }

        //Deck creation.
        public Deck()
        {
            deck = new Stack<Card>();
            foreach (CardValue v in Enum.GetValues(typeof(CardValue)))
            {
                foreach (CardSuite s in Enum.GetValues(typeof(CardSuite)))
                {
                    Card card = new Card(v, s);
                    deck.Push(card);
                }
            }
        }
        
    }
}
