string? str = "This is a string";

//checking using is
if (str is not null)
    Console.WriteLine(str);
else
    Console.WriteLine("str is null");

void DashedLineOldWay(object o)
{
    int l = 0;
    if (o.GetType() == typeof(int))
    {
        l = (int)o;
    }
    string s;
    if (o.GetType() == typeof(string))
    {
        s = (string)o;
        if (!int.TryParse(s, out l))
        {
            l = 0;
        }
    }
    if (l > 0)
    {
        string str = new string('-', l);
        Console.WriteLine(str);
    }
}

// Declaration pattern
void DashedLineNewWay(object o)
{
    if (o is int i || (o is string s && int.TryParse(s, out i)))
        Console.WriteLine(new string('-', i));
}

DashedLineOldWay(12);
DashedLineNewWay(12);
DashedLineOldWay("12");
DashedLineNewWay("12");

// Property pattern examines the properties of an object
bool IsTheIdesOfMarch(DateTime date) => date is { Month: 3, Day: 14 or 15 };

Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 1, 13)));
Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 14)));
Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 15)));
Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 16)));