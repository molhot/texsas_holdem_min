using CardClass;

public class TableClass
{
    public int MinBetMoney
    {
        get;
        set;
    }

    private Card[] TableCards 
    { 
        get; 
        set; 
    }

    public TableClass(int min_betmoney)
    {
        TableCards = [];
        MinBetMoney = min_betmoney;
    }
}