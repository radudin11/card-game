using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGameSix
{

    /**
     * Deck class represents pile of all posible cards based on Suite and Values
     */
    public class Deck
    {
        private Stack<Card> cards = new Stack<Card>();

        //Deck shuffle. 
        public void Shuffle()
        {
            var rnd = new Random();
            var values = cards.ToArray();
            cards.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
                cards.Push(value);
        }

        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.Write(card + " ");
            }
        }

        //Deck creation.
        public Deck()
        {
            cards = new Stack<Card>();
            foreach (CardValue v in Enum.GetValues(typeof(CardValue)))
            {
                foreach (CardSuite s in Enum.GetValues(typeof(CardSuite)))
                {
                    cards.Push(new Card(v, s));
                }
            }
        }
           
            
        public Card Pop()
        {
            return cards.Pop();
        }

        public Stack<Card> getCard()
        {
            return cards;
        }

    }
}
