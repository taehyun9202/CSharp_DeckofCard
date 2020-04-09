using System;
using System.Collections.Generic;
using CardDeck.Models;
namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            d1.Shuffle();
            // d1.Display();
            // Console.WriteLine("****************");
            // Card c1 = d1.Deal();
            // Console.WriteLine(c1.Display());
            // List<Card> hand = d1.Deal(5);
            // Console.WriteLine("****************");
            // foreach(Card c in hand)
            // {
            //     Console.WriteLine(c.Display());
            // }
            // Console.WriteLine(d1.Size);
            Player p1 = new Player(d1);
            p1.Draw(5);
            p1.Display();

        }
    }
}
