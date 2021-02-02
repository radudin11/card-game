using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    public class Card
    {
        public CardValue cardValue;
        public CardSuite cardSign;
        //Possible values.
        public static CardValue[] values = { (CardValue)9, (CardValue)10, (CardValue)12, (CardValue)13, (CardValue)14, (CardValue)15 };
       
        //Possible suites.
        public static CardSuite[] suites = { CardSuite.HEARTS, CardSuite.DIAMONDS, CardSuite.SPADES, CardSuite.CLUBS };
        
        public Card(CardValue value, CardSuite sign)
        {
            this.cardValue = value;
            this.cardSign = sign;
        }

        //Card value => card name.
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
         
            //Card suite => card name.
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
           

            return name;
        }
    }
}
