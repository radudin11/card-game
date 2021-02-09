using System;

namespace cardGameSix
{
    /**
     * Card value class represents the number of a card
     */
    //Card calue class and numeric value for each type of card.
    public enum CardValue : int { NINE = 9, TEN = 10, JACK = 12, QUEEN = 13, KING = 14, ACE = 15 }


    // Define an extension method in a non-nested static class.
    public static class ExtensionsCardValue
    {
        //public static CardValueminPassing = Grades.D;
        public static String Display(this CardValue cardValue)
        {
            
            switch (cardValue)
            {
                case CardValue.ACE:
                    {
                        return "A";
                    }
                case CardValue.JACK:
                    {
                        return  "J";
                        
                    }
                case CardValue.QUEEN:
                    {
                        return  "Q";
                        
                    }
                case CardValue.KING:
                    {
                        return "K";
                    }
                case CardValue.TEN:
                    {
                        return "10";
                    }
                case CardValue.NINE:
                    {
                        return  "9";
                    }
            }
            return "?";
        }
    }
}
