using DeckClass;
using CardClass;

class DeckClassTest
{
    public void NewMakeDeckClass()
    {
        Console.WriteLine("***<Test:make correct class>***");

        Deck mydeck = new Deck(); // 別名を使用
        List<Card> cardlist = mydeck.GetDeckCardList();

        if (cardlist.Count != 52)
        {
            Console.WriteLine(cardlist.Count);
            throw new Exception("deck card count failed!");
        }
        int herts_count = 0;
        int[] herts_number_list = new int[13];
        int diamonds_count = 0;
        int[] diamonds_number_list = new int[13];
        int clubs_count = 0;
        int[] clubs_number_list = new int[13];
        int spades_count = 0;
        int[] spades_number_list = new int[13];

        foreach (var card in cardlist)
        {
            switch(card.GetStyle()) {
                case Card.CardType.Hearts:
                    herts_count = herts_count + 1;
                    herts_number_list[card.GetNumber() - 1] = card.GetNumber();
                    break;
                case Card.CardType.Diamonds:
                    diamonds_count = diamonds_count + 1;
                    diamonds_number_list[card.GetNumber() - 1] = card.GetNumber();
                    break;
                case Card.CardType.Clubs:
                    clubs_count = clubs_count + 1;
                    clubs_number_list[card.GetNumber() - 1] = card.GetNumber();
                    break;
                case Card.CardType.Spades:
                    spades_count = spades_count + 1;
                    spades_number_list[card.GetNumber() - 1] = card.GetNumber();
                    break;
            }
        }

        if (herts_count != 13 || diamonds_count != 13 || clubs_count != 13 || spades_count != 13)
        {
            throw new Exception("count type is failed!");
        }
        int[] number_list = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        if (!herts_number_list.SequenceEqual(number_list) || !diamonds_number_list.SequenceEqual(number_list) || !clubs_number_list.SequenceEqual(number_list) || !spades_number_list.SequenceEqual(number_list))
        {
            throw new Exception("list contents is failed");
        }

        Console.WriteLine("DeckClassInitialize Correct");
        Console.WriteLine("---<Test:end>---\n-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
    }
}