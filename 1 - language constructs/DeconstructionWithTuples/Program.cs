(decimal, decimal, decimal) GetStockValues(string ticker)
{
    if (ticker.Equals("ABCD"))
        return (22m, 19m, 20.5m);
    return (30m, 19m, 20.5m);
}

System.Console.WriteLine(GetStockValues("ABCD"));

var r1 = GetStockValues("ABCD");
System.Console.WriteLine($"{r1.Item1}, {r1.Item2}, {r1.Item3}");

//deconstructing tuple into variables
var (h, w, c) = GetStockValues("ABCD");
System.Console.WriteLine($"{h}, {w}, {c}");

//discard values
decimal c1;
(_, _, c1) = GetStockValues("ABCD");
System.Console.WriteLine($"__, __, {c1}");