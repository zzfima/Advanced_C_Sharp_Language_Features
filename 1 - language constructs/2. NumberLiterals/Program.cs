System.Console.WriteLine("Non using separator");
int d = 123456;
float f = 1234.5f;
var b = 0b1101111010010010;
var x = 0xABCDEF;

System.Console.WriteLine($"{d}");
System.Console.WriteLine($"{f}");
System.Console.WriteLine($"{b:X}");
System.Console.WriteLine($"{x:X}");

//use number separator
System.Console.WriteLine("Using separator");
int d1 = 123_456;
float f1 = 1_234.5f;
var b1 = 0b1101_1110_1001_0010;
var x1 = 0xAB_CD_EF;

System.Console.WriteLine($"{d1}");
System.Console.WriteLine($"{f1}");
System.Console.WriteLine($"{b1:X}");
System.Console.WriteLine($"{x1:X}");