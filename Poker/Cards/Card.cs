using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Cards
{
    internal class Card
    {
        public readonly string name; // номинал карты
        public readonly string suit; // масть карты


        public Card(string suit, string name)
        {
            this.name = name;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{suit}{name}";
        }

    }
}
