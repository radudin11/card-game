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

            //game setup
            Console.WriteLine();
            
            radu = PlayerHand.FillHand(deck , 26);
            tata = PlayerHand.FillHand(deck , 26);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Radu");
            radu.Print();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Tata");
            tata.Print();
            Console.WriteLine("-----------------------");

            //play game
            //game over when 1 hand is empty
            while(radu.GetCards().Count !=0 && tata.GetCards().Count != 0)
            {
                //extract from radu && tata hands the first card and compare
                //          higher value keeps both cards in playerHand
                //         if equal
                //              get value of card
                //              if not enough cards
                //                 extract min length of both hands and 
                //              else
                //                  they extract <value> cards form hand and cycle back
                
            }








        }
    }
}
