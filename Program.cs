using System;

namespace cardGameSix
{
    /**
     * MAN PROGRAM
     */
    static class Program
    {
        
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            PlayerHand radu = new PlayerHand();
            PlayerHand tata = new PlayerHand();

            deck.Shuffle();

            // start game
            Console.WriteLine();
            radu = PlayerHand.FillHand(deck);
            tata = PlayerHand.FillHand(deck);


            Console.WriteLine("Radu");
            radu.Print();
            Console.WriteLine("Tata");
            tata.Print();

            Card trump = deck.getCard().Pop();
            Console.WriteLine("TRUMP CARD = " + trump);
            

            while (deck.getCard().Count > 0)
            {
                Card card = deck.Pop();
                Console.WriteLine(card);
            }






        }
    }
}
