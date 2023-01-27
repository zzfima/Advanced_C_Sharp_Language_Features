// Code to calculate the trade commission
public class CommissionCalculator
{
    public static decimal CalculateTradeCommission(SecuritiesTrade trade) => trade switch
    {
        StockTrade st when st.Quantity == 0 => throw new ArgumentException("Invalid trade"),
        StockTrade st when st.Quantity > 1000 && st.Price * st.Quantity >= 10000.0m => 5.0m,
        StockTrade st when st.Quantity > 1000 => 10.0m,
        StockTrade st when st.Price * st.Quantity >= 5000.0m => (st.Price * st.Quantity) * 0.005m,
        StockTrade st => (st.Price * st.Quantity) * 0.01m,

        BondTrade bt when bt.Duration == 5 && bt.Quantity * bt.Price >= 10000.0m => 15.0m,
        BondTrade bt when bt.Duration == 5 => 20.0m,
        BondTrade bt when bt.Duration == 10 => 12.0m,
        BondTrade bt when bt.Duration == 20 && bt.Quantity * bt.Price >= 5000.0m => 5.0m,
        BondTrade bt when bt.Duration == 20 => 10.0m,

        _ => throw new ArgumentException("Unknown")
    };


    public static void PrintTradeCommission(SecuritiesTrade trade)
    {
        decimal commission = 0.0m;

        commission = CalculateTradeCommission(trade);
    }
}