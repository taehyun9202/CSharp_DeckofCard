using System;
using System.Collections.Generic;
namespace CardDeck.Models
{
    public class Player
    {
        public string Name;
        private List<Card> _hand;
        private Deck _deckInstance;

        public Player(Deck deckInstnace, string name = "Tyler")
        {
            Name = name;
            _hand = new List<Card>();
            _deckInstance = deckInstnace;
        }

        public void Draw(int num = 1)
        {
            List<Card> newCards = _deckInstance.Deal(num);
            foreach(Card card in newCards)
            {
                _hand.Add(card);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is holding {_hand.Count} card(s)");
            foreach(Card card in _hand)
            {
                Console.WriteLine(card.Display());
            }
        }
    }
}