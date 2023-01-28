class StockRecord
{
    string[] _stocksPerDay;
    public StockRecord()
    {
        _stocksPerDay = new string[] { "A", "B", "C" };
    }

    //stock indexer
    public string this[int index]
    {
        get => _stocksPerDay[index];
        set => _stocksPerDay[index] = value;
    }

    //overridden indexer
    public int this[string day]
    {
        get
        {
            switch (day)
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                default: return -1;
            }
        }
    }
}