using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    public class Card
    {
        public CardValue cardValue;
        public CardSuite cardSign;
        public static CardValue[] values = { (CardValue)9, (CardValue)10, (CardValue)12, (CardValue)13, (CardValue)14, (CardValue)15 };
        // All possible values for a card for the deck formation.

        public static CardSuite[] signs = { CardSuite.HEARTS, CardSuite.DIAMONDS, CardSuite.SPADES, CardSuite.CLUBS };
        // All possible signs for a card for the deck formation.
        public Card(CardValue value, CardSuite sign)
        {
            this.cardValue = value;
            this.cardSign = sign;
        }

        override public string ToString()
        {
            string name = "";
          
            switch (cardValue)
            {
                case CardValue.ACE:
                    {
                        name += "A";
                        break;
                    }
                case CardValue.JACK:
                    {
                        name += "J";
                        break;
                    }
                case CardValue.QUEEN:
                    {
                        name += "Q";
                        break;
                    }
                case CardValue.KING:
                    {
                        name += "K";
                        break;
                    }
                case CardValue.TEN:
                    {
                        name += "10";
                        break;
                    }
                case CardValue.NINE:
                    {
                        name += "9";
                        break;
                    }



            }
            // Asociating the value of the card to the name.
            switch (cardSign)
            {
                case CardSuite.SPADES:
                    {
                        name += "S";
                        break;
                    }
                case CardSuite.CLUBS:
                    {
                        name += "C";
                        break;
                    }
                case CardSuite.DIAMONDS:
                    {
                        name += "D";
                        break;
                    }
                case CardSuite.HEARTS:
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
