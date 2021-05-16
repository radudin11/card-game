using System;

namespace cardGameSix
{
    /**
     * Card value class represents the number of a card
     */
    //Card calue class and numeric value for each type of card.
    public class CardValue
    {
        int value;

        public CardValue(int i)
        {
            value = i;
        }

        public String Display()
        {

            switch (value)
            {
                case 15:
                    {
                        return "A";
                    }
                case 14:
                    {
                        return "K";
                    }
                case 13:
                    {
                        return "Q";

                    }
                case 12:
                    {
                        return "J";

                    }

                    
            }
            return ""+value;
        }

        public int GetValue()
        {
            return value;
        }
    }

  
}
