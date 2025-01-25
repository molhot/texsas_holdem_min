using CardClass;

class CardClassTest
{
    public void NewMakeCardClass()
    {
        Card myCard = new Card(1, "Hearts", true); // 別名を使用

        if (myCard.GetNumber() != 1 || myCard.GetStyle() != "Hearts" || !myCard.GetStatus())
        {
            throw new Exception("TestCardInitialization failed!");
        }

        Console.WriteLine("TestCardInitialization passed.");
    }
}