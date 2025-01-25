using CardClass;

class CardClassTest
{
    public void NewMakeCardClass()
    {
        Console.WriteLine("***<Test:make correct class>***");

        Card myCard = new Card(1, Card.CardType.Hearts, true); // 別名を使用

        if (myCard.GetNumber() != 1 || myCard.GetStyle() != Card.CardType.Hearts || !myCard.GetStatus())
        {
            throw new Exception("TestCardInitialization failed!");
        }

        Console.WriteLine("TestCardInitialization passed.");
        Console.WriteLine("---<Test:end>---\n-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
    }

    public void IsCardClassFalseNumber()
    {
        Console.WriteLine("***<Test:make false number class>***");

        try
        {
            Card myCard = new Card(100, Card.CardType.Hearts, true);
            throw new Exception("TestCardInitialization failed!");
        } catch (Card.IsNotCorrectNumber){
            Console.WriteLine("TestCardInitialization passed.");
            Console.WriteLine("---<Test:end>---\n-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}