namespace CardClass
{
    public class Card
    {
        public enum CardType
        {
            Hearts,
            Diamonds,
            Clubs,
            Spade
        }

        public class IsNotCorrectNumber : Exception
        {
            public IsNotCorrectNumber(string message) : base(message)
            {

            }
        }
        private int Number;
        private CardType Style;
        private bool Status;

        public Card(int cardnumber, CardType style, bool status)
        {
            SetNumber(cardnumber);
            Style = style;
            Status = status;
        }

        public int GetNumber()
        {
            return Number;
        }

        private void SetNumber(int cardnumber)
        {
            if (!(1 <= cardnumber && cardnumber <= 13))
            {
                throw new IsNotCorrectNumber("card numberには1~13の値を入れてください");
            }
            Number = cardnumber;
        }

        public CardType GetStyle()
        {
            return Style;
        }

        public bool GetStatus()
        {
            return Status;
        }
    }
}
