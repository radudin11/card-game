using System;

namespace cardGameSix
{
    /**
     * Card suite class represents the suite of a card (heart,...) along with a associated number
     */
    //Card suite class and asociated values for each suite
    public enum CardSuite : int { HEARTS = 1, DIAMONDS = 2, SPADES = 3, CLUBS = 4 };

    // Define an extension method in a non-nested static class.
    public static class ExtensionsCardSuite
    {
        //public static CardValueminPassing = Grades.D;
        public static String Display(this CardSuite cardSuite)
        {
            //Card suite => card name.
            switch (cardSuite)
            {
                case CardSuite.SPADES:
                    {
                        return "S";
                    }
                case CardSuite.CLUBS:
                    {
                        return "C";
                    }
                case CardSuite.DIAMONDS:
                    {
                        return "D";
                    }
                case CardSuite.HEARTS:
                    {
                        return "H";
                    }

            }
            return "?";
        }
    }
}


