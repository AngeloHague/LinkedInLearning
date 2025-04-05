// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Typed function
float MilesToKm(float miles) {
    float res = miles * 1.6f;
    return res;
}

float miles = 10.0f;
Console.WriteLine($"{miles} Miles in km: {MilesToKm(miles)}");

// Void function with named and default params
void PrintWithPrefix(string str, string prefix="") {
    Console.WriteLine($"{prefix} {str}");
}

PrintWithPrefix("hello!",":: >");
PrintWithPrefix("hello!"); // no prefix, use default

// call with named params:
PrintWithPrefix(prefix: "!!", str: "hello!"); // no prefix, use default

