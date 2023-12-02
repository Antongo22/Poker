using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Cards
{
    internal class Cards
    {
        static Dictionary<Card, string> cardsPictures = new Dictionary<Card, string>(); // Хранение всех карт

        static List<Card> cards; // список для всех карт на поле

        public readonly static string[] suits = { "Cross", "Bubi", "Spades", "Chervi" }; //крести буби пики черви
        public readonly string[] names = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; // номиналы карт

        public Cards() 
        { 
            SetCards();
        }


        /// <summary>
        /// Задаём карты на поле
        /// </summary>
        void SetCards()
        {
            if (cards != null)
            {
                throw new Exception("Игровое поле уже задано!");
            }

            cards = new List<Card>();

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    cards.Add(new Card(suits[i], names[j]));
                }
            }
        }

    }
}
