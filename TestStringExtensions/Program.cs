using StringExtensionsLibrary;

string testString = "Hello World";
Console.WriteLine($"Does '{testString}' start with an uppercase letter? {testString.StartsWithUpper()}");

testString = "hello World";
Console.WriteLine($"Does '{testString}' start with an uppercase letter? {testString.StartsWithUpper()}");
