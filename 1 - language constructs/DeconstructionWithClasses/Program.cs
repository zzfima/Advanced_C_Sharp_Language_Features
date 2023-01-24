
Planet earth = new Planet("Earth", 6371, 1, 150_980_000);
System.Console.WriteLine(earth);

var (name1, moonCount1) = earth;
System.Console.WriteLine($"{name1}, {moonCount1}");

var (name2, moonCount2, radius2) = earth;
System.Console.WriteLine($"{name2}, {moonCount2}, {radius2}");