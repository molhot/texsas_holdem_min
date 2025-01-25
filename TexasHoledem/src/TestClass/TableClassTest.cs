using TableClass;

class TableClassTest
{
    public void NewMakeTableClass()
    {
        Console.WriteLine("***<Test:make correct class>***");

        Table table = new Table(0);
        if (table.MinBetMoney != 0)
        {
            throw new Exception("Table Class Initialize failed!");
        }
        Console.WriteLine("TableCardInitialization passed.");
        Console.WriteLine("---<Test:end>---\n-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
    }
}