namespace cardGameSix
{
    /**
     * Card class represents the playing card which has a Value and a Sign
     */
    public class Card
    {
        public CardValue cardValue;
        public CardSuite cardSuite;

        
        public Card(int value, CardSuite suite)
        {
            this.cardValue = new CardValue(value);
            this.cardSuite = suite;
        }

        //Card value => card name.
        override public string ToString() => cardValue.Display() + cardSuite.Display();

       
    }
}
