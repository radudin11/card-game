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
            deck.Print();
            deck.Shuffle();
            Console.WriteLine();
            deck.Print();  
        }
    }
}
