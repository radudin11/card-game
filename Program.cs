using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGameSix
{
    public enum Value:int { NINE = 9, TEN = 10, JACK = 12, QUEEN = 13, KING = 14, ACE = 15  };
    public enum Sign:int { HEARTS = 1, DIAMONDS = 2, SPADES = 3, CLUBS  = 4};
    public class Card
    {
        public Value value;
        public Sign sign;
        public static Value[] values = {(Value)9 , (Value)10, (Value)12 , (Value)13 , (Value)14, (Value)15 };
        public static Sign[] signs = { Sign.HEARTS , Sign.DIAMONDS , Sign.SPADES , Sign.CLUBS };
        
        public Card(Value value, Sign sign)
        {
            this.value = value;
            this.sign = sign;
        }

        override public string ToString()
        {
            string name = "";
            switch (value)
            {
                case Value.ACE:
                    {
                        name += "A";
                        break;
                    }
                case Value.JACK:
                    {
                        name += "J";
                        break;
                    }
                case Value.QUEEN:
                    {
                        name += "Q";
                        break;
                    }
                case Value.KING:
                    {
                        name += "K";
                        break;
                    }
                case Value.TEN:
                    {
                        name += "10";
                        break;
                    }
                case Value.NINE:
                    {
                        name += "9";
                        break;
                    }



            }

            switch (sign)
            {
                case Sign.SPADES:
                    {
                        name += "S";
                        break;
                    }
                case Sign.CLUBS:
                    {
                        name += "C";
                        break;
                    }
                case Sign.DIAMONDS:
                    {
                        name += "D";
                        break;
                    }
                case Sign.HEARTS:
                    {
                        name += "H";
                        break;
                    }


            }
            return name;
        }
    }

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
            foreach( Card card in deck)
            {
                Console.Write(card + " ");
            }
        }
        public Deck()
        {
            deck = new Stack<Card>();
            foreach (Value v in Card.values)
            {
                foreach(Sign s in Card.signs)
                {
                    Card card = new Card(v , s);
                    deck.Push(card);
                }
            }
        }
    }
    static class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            deck.Print();
            deck.Shuffle();
            Console.WriteLine();
            deck.Print();
            
            
            
        }
    }
}
