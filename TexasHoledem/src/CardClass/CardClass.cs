namespace CardClass
{
    public class Card
    {
        private int Number;
        private string Style;
        private bool Status;

        public Card(int cardnumber, string style, bool status)
        {
            Number = cardnumber;
            Style = style;
            Status = status;
        }

        public int GetNumber()
        {
            return Number;
        }

        public string GetStyle()
        {
            return Style;
        }

        public bool GetStatus()
        {
            return Status;
        }
    }
}
