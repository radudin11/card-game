using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGameSix
{
    
    static class Program
    {
        
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            PlayerHand playerHand = new PlayerHand();
            deck.Print();
            deck.Shuffle();
            Console.WriteLine();
            deck.Print();
            Console.WriteLine();
            playerHand.Fill(deck);
            playerHand.Print();
            Card cardExtracted = playerHand.Extract(1);
            Console.WriteLine(cardExtracted);
            playerHand.Print();
            deck.Print();




        }
    }
}
