// Test code to test the trade commission calculation algorithm:
SecuritiesTrade[] tradeList = new SecuritiesTrade[] {
    new StockTrade(){Symbol="ABCD", Quantity=1200, Price=27.81m},
    new StockTrade(){Symbol="WXYZ", Quantity=1000, Price=7.92m},
    new StockTrade(){Symbol="ABCD", Quantity=200, Price=27.81m},
    new StockTrade(){Symbol="WXYZ", Quantity=400, Price=7.92m},
    new StockTrade(){Symbol="WXYZ", Quantity=0, Price=9.55m},
    new BondTrade(){Name="Abcd 5yr", Duration=5, Price=100.0m, Quantity=10},
    new BondTrade(){Name="Qwert 10yr", Duration=10, Price=100.0m, Quantity=10},
    new BondTrade(){Name="Abcd 20yr", Duration=20, Price=100.0m, Quantity=100},
    new BondTrade(){Name="Qwert 20yr", Duration=20, Price=50.0m, Quantity=10},
    new BondTrade(){Name="Qwert 50yr", Duration=50, Price=50.0m, Quantity=10},
};

foreach (var tradeItem in tradeList)
{
    try
    {
        CommissionCalculator.PrintTradeCommission(tradeItem);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"{e.Message}");
    }
}