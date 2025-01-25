using CardClass;

namespace TableClass
{
    public class Table
    {
        public int MinBetMoney
        {
            get;
            set;
        }

        private Card[] TableCards = new Card[5];

        public Table(int min_betmoney)
        {
            MinBetMoney = min_betmoney;
        }

        public void SetTableCards(int number, Card opend_card)
        {
            TableCards[number] = opend_card;
        }
    }
}