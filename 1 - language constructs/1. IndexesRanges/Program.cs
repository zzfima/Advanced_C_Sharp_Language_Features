//define simple array

var words = new string[]{
    "The","quick","brown","fox","jumps",
    "over","the","lazy","dog"
};

//index operator
Console.WriteLine(words[1]);

//range
System.Console.WriteLine($"Range: {String.Join(", ",  words[1..3])}");
System.Console.WriteLine($"Range: {String.Join(", ", words[3..])}");
System.Console.WriteLine($"Range: {String.Join(", ", words[..5])}");

//range can be variables too
Range rng1 = 3..5;
System.Console.WriteLine($"Range as variable: {String.Join(", ", words[rng1])}");
Range rng2 = 3..^4;
System.Console.WriteLine($"Range as variable: {String.Join(", ", words[rng2])}");

//index from the end
Console.WriteLine(words[^1]);

//indexes can be variables too
Index idx1 = ^1;
System.Console.WriteLine($"At index 4: {words[idx1]}");
