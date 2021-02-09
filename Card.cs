namespace cardGameSix
{
    /**
     * Card class represents the playing card which has a Value and a Sign
     */
    public class Card
    {
        public CardValue cardValue;
        public CardSuite cardSuite;
        
        public Card(CardValue value, CardSuite suite)
        {
            this.cardValue = value;
            this.cardSuite = suite;
        }

        //Card value => card name.
        override public string ToString() => cardValue.Display() + cardSuite.Display();
    }
}
