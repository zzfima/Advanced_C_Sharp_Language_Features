// Main use case for the positional pattern:
// matching against multiple values in a tuple

decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate) => (groupSize, visitDate.DayOfWeek) switch
{
    ( <= 0, _) => throw new ArgumentException("Group size must be a positive number"),
    (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
    ( >= 5 and < 10, DayOfWeek.Monday) => 0.2m,
    ( >= 10, DayOfWeek.Monday) => 0.3m,
    ( >= 5 and < 10, _) => 0.12m,
    ( >= 10, _) => 0.15m,
    _ => 0.0m,
};

(int, DateTime)[] TestDiscountData = new[] {
    (4, new DateTime(2022, 9, 3)),
    (7, new DateTime(2023, 2, 6)),
    (20, new DateTime(2023, 4, 17)),
    (15, new DateTime(2023, 8, 8)),
    (9, new DateTime(2023, 8, 9)),
};

// iterate over each of the test data items and evaluate the discount
foreach ((var size, var date) in TestDiscountData)
{
    decimal discount = GetGroupTicketPriceDiscount(size, date);
    Console.WriteLine($"The discount for a group \t of {size} \t on {date:ddd, MMM, d} \t is {discount}");
}

//use the implicit deconstruct call to switch on the different values of class
Point[] testPointData = new[]{
    new Point(5, 8),
    new Point(-2, 7),
    new Point(1, -1),
    new Point(-2, -2),
};

string classify(Point p) => p switch
{
    ( > 0, > 0) => "Upper right",
    ( < 0, > 0) => "Upper left",
    ( > 0, < 0) => "Lower right",
    ( < 0, < 0) => "Lower left",
    (0, 0) => "Center",
    _ => throw new Exception("strange...")
};

foreach (var p in testPointData)
{
    var (x, y) = p;
    System.Console.WriteLine($"{x}, {y}");
    System.Console.WriteLine($"Classify: {classify(p)}");
}


public readonly struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y) => (X, Y) = (x, y);
    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}