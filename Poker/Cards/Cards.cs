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
        /// Обновление калоды
        /// </summary>
        void UpdateCards() { }

        /// <summary>
        /// Показ одной новой карты из калоды
        /// </summary>
        /// <param name="number">Количество карт, которые нужно показать</param>
        void ShowCards(int number) { }

        /// <summary>
        /// Раздача карт игрокам
        /// </summary>
        /// <param name="countofPlayers">количество игроков</param>
        void DealingCards(int countofPlayers) { }

        /// <summary>
        /// Перемешивание карт
        /// </summary>
        public void ShuffleCards()
        {
            Random random = new Random();

            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }

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
