void OldSchoolLogString(string? str)
{
    if (str == null)
        System.Console.WriteLine("string is null");
    else
        System.Console.WriteLine(str);
}
OldSchoolLogString("hello");
OldSchoolLogString(null);

void NewSchoolLogString(string? str) => System.Console.WriteLine(str ?? "string is null"); //choose value on the left if is not a null, otherwise choose right value
NewSchoolLogString("hello");
NewSchoolLogString(null);

void ThrowableLogString(string? str) => System.Console.WriteLine(str ?? throw new ArgumentNullException("string is null"));
ThrowableLogString("hello");
try
{
    ThrowableLogString(null);
}
catch (System.Exception e)
{
    System.Console.WriteLine(e.Message);
}

//string coalescing assign variable if null
string? str1 = null;
str1 ??= "Default value";
System.Console.WriteLine(str1);

string? str2 = "Some value";
str2 ??= "Default value";
System.Console.WriteLine(str2);