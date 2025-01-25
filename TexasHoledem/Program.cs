using System;
using CardClass;

class Program
{
    static void Main(string[] args)
    {
        var test = new CardClassTest();
        test.NewMakeCardClass();
        test.IsCardClassFalseNumber();

        var test_2 = new DeckClassTest();
        test_2.NewMakeDeckClass();
    }
}
