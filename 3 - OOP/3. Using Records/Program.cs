var dt1 = new DayTemperature(11.2m, 4.5m);
var dt2 = new DayTemperature(44.5m, 17.1m);
var dt3 = new DayTemperature(11.2m, 4.5m);

System.Console.WriteLine(dt1 == dt2);
System.Console.WriteLine(dt1 == dt3);

System.Console.WriteLine(dt1);
var (h, l) = dt1;
System.Console.WriteLine($"{h}, {l}, {dt1.Average}");

//error - immutable
//dt1.High = 11;

var dt4 = dt1 with { Low = 0.2m };
System.Console.WriteLine(dt4);

//
public partial record DayTemperature(decimal High, decimal Low);

public partial record DayTemperature
{
    public decimal Average => (High + Low) / 2;
}