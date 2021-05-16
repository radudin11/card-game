using System;
using System.Collections.Generic;
namespace cardGameSix
{
    /**
     * MAN PROGRAM
     */
    
    static class Program
    {
        public static Queue<Card> pile = new Queue<Card>();
        public static int verify(PlayerHand Player1, PlayerHand Player2)
        {
            Card card1 = Player1.ExtractCard(0);
            Card card2 = Player2.ExtractCard(0);
            Console.WriteLine(card1 + " vs " + card2);
            Console.WriteLine();
            pile.Enqueue(card1);
            pile.Enqueue(card2);


            //higher value keeps both cards in playerHand
            if (card2.cardValue.GetValue() > card1.cardValue.GetValue())
            {
                while (pile.Count != 0)
                {
                    Player2.GetCards().Add(pile.Dequeue());

                    
                }
                return 2;
            }
           if(card2.cardValue.GetValue() < card1.cardValue.GetValue())
            {

                while (pile.Count != 0)
                {
                    Player1.GetCards().Add(pile.Dequeue());

                }
                return 1;
            }

            

            //         if equal
            if (card2.cardValue.GetValue() == card1.cardValue.GetValue())
            {
                if (Player1.GetCards().Count == 0)
                    return 2;
                if (Player2.GetCards().Count == 0)
                    return 1;
                Console.WriteLine(card2.cardValue.GetValue());
                Console.WriteLine(Player1.GetCards().Count);
                Console.WriteLine(Player2.GetCards().Count);
                Console.WriteLine("tata:");
                Player1.Print();
                Console.WriteLine("radu:");
                Player2.Print();

                int min = Math.Min(Math.Min(Player1.GetCards().Count, Player2.GetCards().Count), card2.cardValue.GetValue());
                for (int i = 1; i < min ; i++)
                {
                    Card card11 = Player1.ExtractCard(0);
                    Card card22 = Player2.ExtractCard(0);
                    pile.Enqueue(card11);
                    pile.Enqueue(card22);
                    Console.WriteLine(card11 + " and " + card22);
                    Console.WriteLine();
                    

                }
                return verify(Player1, Player2);
            }
            return 0;
        }

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
            Console.WriteLine("Tata");
            tata.Print();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Radu");
            radu.Print();
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            //play game
            //game over when 1 hand is empty
            int ver = 0;
            while(radu.GetCards().Count !=0 && tata.GetCards().Count != 0)
            {
                
                ver = verify(tata, radu);
                //extract from radu && tata hands the first card and compare
                if(ver == 1)
                {
                    Console.WriteLine("Tata keeps the cards!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Radu keeps the cards!");
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------");


                //              get value of card
                //              if not enough cards
                //                 extract min length of both hands and 
                //              else
                //                  they extract <value> cards form hand and cycle back

            }
            Console.WriteLine("tata:");
            tata.Print();
            Console.WriteLine();
            Console.WriteLine("radu:");
            radu.Print();
            Console.WriteLine();
            if (ver == 1)
            {
                Console.WriteLine("Tata wins!");
            }
            else
            {
                Console.WriteLine("Radu wins!");
            }









        }
    }
}
