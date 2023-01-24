public class Planet
{
    public string Name { get; set; }
    public int Radius { get; set; }
    public int MoonCount { get; set; }
    public int DistanceFromSunKm { get; set; }

    public Planet(string name, int radius, int moonCount, int distanceFromSunKm)
    {
        Name = name;
        Radius = radius;
        MoonCount = moonCount;
        DistanceFromSunKm = distanceFromSunKm;
    }

    public override string ToString()
    {
        return $"{Name}, {Radius}, {MoonCount}, {DistanceFromSunKm}";
    }

    //define Deconstruct method, returns the name and moon count
    public void Deconstruct(out string name, out int moons)
    {
        name = Name;
        moons = MoonCount;
    }

    //define Deconstruct method, returns the name, moon count and radius
    public void Deconstruct(out string name, out int moonCount, out int radius)
    {
        name = Name;
        moonCount = MoonCount;
        radius = Radius;
    }
}