﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cardGameSix
{
    public class Card
    {
        public CardValue cardValue;
        public CardSign cardSign;
        public static CardValue[] values = { (CardValue)9, (CardValue)10, (CardValue)12, (CardValue)13, (CardValue)14, (CardValue)15 };
        

        public static CardSign[] signs = { CardSign.HEARTS, CardSign.DIAMONDS, CardSign.SPADES, CardSign.CLUBS };
        
        public Card(CardValue value, CardSign sign)
        {
            this.cardValue = value;
            this.cardSign = sign;
        }

        public Card()
        {
            this.cardValue = 0;
            this.cardSign = 0;
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
           
            switch (cardSign)
            {
                case CardSign.SPADES:
                    {
                        name += "S";
                        break;
                    }
                case CardSign.CLUBS:
                    {
                        name += "C";
                        break;
                    }
                case CardSign.DIAMONDS:
                    {
                        name += "D";
                        break;
                    }
                case CardSign.HEARTS:
                    {
                        name += "H";
                        break;
                    }


            }
            

            return name;
        }
    }
}
