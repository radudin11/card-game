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
            // Moving all the elemnts of the stack(deck) to an array in order to randomize.
            foreach (var value in values.OrderBy(x => rnd.Next()))
                deck.Push(value);
            // Recreating the stack in a random order.
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
            foreach (Value v in Card.values)
            {
                foreach (Sign s in Card.signs)
                {
                    Card card = new Card(v, s);
                    deck.Push(card);
                }
            }
        }
        // Using the card class we can easily create the deck as we already have all the possible 
        // options for the values and signs.
    }
}
