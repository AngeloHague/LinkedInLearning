// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int i = 10; // integers
float f = 2.0f; // floats
decimal d = 10.0m; // decimal
bool b = true; // boolean
char c = 'c'; // character
string s = "A string"; // strings - collections of chars
var x = 10; /// implicit variable
var z = "Hello"; // implicity variable - string

int[] arr = new int[5]; // empty array of 5 integers
string[] strs = {"one", "two", "three"}; // array of 3 preset strings

Console.WriteLine("Here are some variables:");
Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", i, f, d, b, c, s, x, z);
Console.WriteLine("Array: {0}", arr[0]); // prints 0, as the array is empty
Console.WriteLine("Array: {0}", strs[0]); // prints "one"


object obj = null;
Console.WriteLine("Object: {0}", obj); // prints "Object: "

long bignum;
bignum = i; // implicit conversion from int to long
Console.WriteLine("Implicit bignum: {0}", bignum); // prints "Implicit conversion: 10"

float i_to_f = (float)i; // explicit conversion from int to float
Console.WriteLine("Explicit conversion: {0}", i_to_f); // prints "Explicit conversion: 10"

float f_to_i = (int)f; // explicit conversion from int to float
Console.WriteLine("Explicit conversion: {0}", f_to_i); // prints "Explicit conversion: 2"