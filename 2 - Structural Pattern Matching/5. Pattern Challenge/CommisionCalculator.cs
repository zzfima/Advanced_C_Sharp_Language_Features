// Code to calculate the trade commission
// The rules:
// A Stock trade of 0 shares should be caught and flagged as invalid
// A Stock trade that is less than $5,000 is a 0.1% commission
// A Stock trade that is more or equal to $5,000 is a 0.05% commission
// Any stock trade of 1,000 shares or more is a flat fee of $10
// Any Stock trade of 1,000 shares or more with a value of $10,000 or more is a flat fee of $5
// A Bond trade of 5 years duration is $20, or $15 if the total trade value is $10,000 or more
// Any bond trade of 10 years duration is $12
// A Bond trade of 20 years duration is $10, or $5 if the total value is $5,000 or more
// A Bond trade of any other duration should be caught and flagged as invalid

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

        switch (trade)
        {
            case StockTrade st:
                System.Console.WriteLine($"Stock Trade of {st.Quantity} of {st.Symbol} is ${commission}");
                break;
            case BondTrade bt:
                System.Console.WriteLine($"Bond Trade of {bt.Quantity} of {bt.Name} is ${commission}");
                break;
        }
    }
}