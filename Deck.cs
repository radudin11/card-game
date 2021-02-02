using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cardGameSix
{
    
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
            foreach (CardValue v in Card.values)
            {
                foreach (CardSuite s in Card.suites)
                {
                    Card card = new Card(v, s);
                    deck.Push(card);
                }
            }
        }
        
    }
}
