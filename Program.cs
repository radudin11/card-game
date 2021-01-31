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
            deck.Print();
            deck.Shuffle();
            Console.WriteLine();
            deck.Print();
            
            
            
        }
    }
}
