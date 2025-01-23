using Card;

public class UserClass
{
    public bool MinBetMoney
    {
        get;
        set;
    }

    private Card[] TableCards 
    { 
        get; 
        set; 
    }

    public UserClass(int min_betmoney)
    {
        TableCards = [];
        MinBetMoney = min_betmoney;
    }
}