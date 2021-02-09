using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cardGameSix
{
    public class Deck
    {
        Stack<Card> deck = new Stack<Card>();
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
        public Deck()
        {
            deck = new Stack<Card>();
            foreach (CardValue v in Card.values)
            {
                foreach (CardSign s in Card.signs)
                {
                    Card card = new Card(v, s);
                    deck.Push(card);
                }
            }
        }
        public Card Pop()
        {
            Card card = deck.Pop();
            return card;
        }
       
    }
}
