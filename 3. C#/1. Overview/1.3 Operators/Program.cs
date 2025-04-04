// See https://aka.ms/new-console-template for more information

int x=10, y=5; // integers
string a="abcd", b="efgh"; // strings

Console.WriteLine("\n--- Basic Math ---");
Console.WriteLine((x/y)*x);
Console.WriteLine(a+b);

// Standard increment and decrement operators
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);

a += b;
Console.WriteLine(a);
Console.WriteLine(b);


Console.WriteLine("\n--- Logical Operators: &&, || ---");
Console.WriteLine(x > y && y>= 5);
Console.WriteLine(x > y || y>= 5);


Console.WriteLine("\n--- Null-coalescing Operators: &&, || ---");
string str = null;
Console.WriteLine($"Fallback: {str ?? "Unknown value"}"); // prints "Default value"
Console.WriteLine($"Str Value: {str}"); // prints ""
Console.WriteLine($"Assign null value: {str ??= "New value"}"); // prints "Default value"
Console.WriteLine($"Str Value: {str}"); // prints "Default value"


