
//given date determine what quarter is

string getQuarterFromDate(DateTime dateTime) => dateTime.Month switch
{
    (>= 1 and <= 3) => "Q1",
    (>= 4 and <= 6) => "Q2",
    (>= 7 and <= 9) => "Q3",
    (>= 10 and <= 12) => "Q4",
    _ => throw new Exception("strange")
};

var dt = new DateTime(2023, 1, 27);
System.Console.WriteLine($"Quarter of {dt.ToShortDateString()} is {getQuarterFromDate(dt)}");
dt = new DateTime(2023, 5, 13);
System.Console.WriteLine($"Quarter of {dt.ToShortDateString()} is {getQuarterFromDate(dt)}");

//given date determine if its falls into first or second half of year


HalfOfYear getHalfOfYearFromDate1(DateTime dt) => dt.DayOfYear switch
{
    (>= 1 and <= 182) => HalfOfYear.First,
    (>= 183 and <= 365) => HalfOfYear.Second,
    _ => throw new Exception("strange")
};

HalfOfYear getHalfOfYearFromDate2(object dt)
{
    if (dt is DateTime { Month: <= 6 })
        return HalfOfYear.First;
    else if (dt is DateTime { Month: > 6 })
        return HalfOfYear.Second;
    throw new Exception("strange");
}

dt = new DateTime(2023, 1, 27);
System.Console.WriteLine($"Quarter of {dt.DayOfYear} is {getHalfOfYearFromDate1(dt)}");
System.Console.WriteLine($"Quarter of {dt.DayOfYear} is {getHalfOfYearFromDate2(dt)}");
dt = new DateTime(2023, 9, 27);
System.Console.WriteLine($"Quarter of {dt.DayOfYear} is {getHalfOfYearFromDate1(dt)}");
System.Console.WriteLine($"Quarter of {dt.DayOfYear} is {getHalfOfYearFromDate2(dt)}");

enum HalfOfYear { First, Second, }