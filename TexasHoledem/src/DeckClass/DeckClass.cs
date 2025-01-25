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
        }

        public List<Card> GetDeckCardList()
        {
            return DeckCardList;
        }
    }
}