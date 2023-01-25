//common switch statement
string NumToStringUpToThree(int num)
{
    switch (num)
    {
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        default:
            return "Unknown";
    }
}
Console.WriteLine(NumToStringUpToThree(2));

//enhanced switch statement
string ShapesToString1(object shape)
{
    switch (shape)
    {
        case Circle:
            return "Circle shape";
        case Rectangle:
            return "Rectangle shape";
        case Triangle:
            return "Triangle shape";
        default:
            return "Unknown";
    }
}
Console.WriteLine(ShapesToString1(new Triangle { Base = 22, Height = 11 }));

//more enhanced switch statement
string ShapesToString2(object shape)
{
    switch (shape)
    {
        case Circle c:
            return "Circle shape: " + c.Radius;
        case Rectangle r:
            return "Rectangle shape: " + r.Length + ", " + r.Width;
        case Triangle t:
            return "Triangle shape: " + t.Base + ", " + t.Height;
        default:
            return "Unknown";
    }
}
Console.WriteLine(ShapesToString2(new Triangle { Base = 22, Height = 11 }));

//more more enhanced switch statement using switch expression
string ShapesToString3(object shape) => shape switch
{
    Circle c when c.Radius > 3 => "Big Circle shape: " + c.Radius,
    Circle { Radius: var r } when r <= 3 => "Small Circle shape: " + r,
    Rectangle r => "Rectangle shape: " + r.Length + ", " + r.Width,
    Triangle t => "Triangle shape: " + t.Base + ", " + t.Height,
    _ => "Unknown"
};

Console.WriteLine(ShapesToString3(new Circle { Radius = 5 }));
Console.WriteLine(ShapesToString3(new Circle { Radius = 1 }));
Console.WriteLine(ShapesToString3(new Random()));