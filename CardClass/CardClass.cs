namespace Card
{
    public class Card
    {
        public int Number
        {
            get;
            set;
        }

        public string Style
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

        public Card(int cardnumber, string style, bool status)
        {
            Number = cardnumber;
            Style = style;
            Status = status;
        }
    }
}