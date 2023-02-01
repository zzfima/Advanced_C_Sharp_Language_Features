/*
Object methods
    ToString
    Еquals(Object)
    GetHashCode
    GetType
    MemberwiseClone
*/

var x = 4.56f;
var str = x.ToString();
System.Console.WriteLine($"{str}");

var p = new Person { LastName = "Abramov", Age = 33 };
System.Console.WriteLine(p);
var (a, fn) = p;
System.Console.WriteLine("*** " + fn);

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age} years old";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person p && p.Age == Age && p.FirstName == FirstName && p.LastName == LastName)
            return true;
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public void Deconstruct(out int a, out string fn) => (a, fn) = (Age, FirstName ?? "Default name");
}