using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    public class Card
    {
        public Value value;
        public Sign sign;
        public static Value[] values = { (Value)9, (Value)10, (Value)12, (Value)13, (Value)14, (Value)15 };
        // All possible values for a card for the deck formation.

        public static Sign[] signs = { Sign.HEARTS, Sign.DIAMONDS, Sign.SPADES, Sign.CLUBS };
        // All possible signs for a card for the deck formation.
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
            // Asociating the value of the card to the name.
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
            // Asociating the sign of the card to the name.

            return name;
        }
    }
}
