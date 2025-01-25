using System.Runtime.CompilerServices;
using CardClass;

namespace DeckClass
{
    public class Deck
    {
        private List<Card> DeckCardList = new List<Card>();
        public Card.CardType[] CardTypeList = {Card.CardType.Hearts, Card.CardType.Clubs, Card.CardType.Diamonds, Card.CardType.Spades};
        int[] number_list = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

        public Deck()
        {
            foreach (Card.CardType cardtype in CardTypeList)
            {
                foreach (int number in number_list)
                {
                    DeckCardList.Add(new Card(number, cardtype, false));
                }
            }
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            int n = DeckCardList.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1); // 0 から n までのランダムなインデックス
                var value = DeckCardList[k];
                DeckCardList[k] = DeckCardList[n];
                DeckCardList[n] = value;
            }
        }

        public List<Card> GetDeckCardList()
        {
            return DeckCardList;
        }
    }
}