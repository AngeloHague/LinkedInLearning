

string outstr;

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string!";
string str3 = "THIS is a STRING!";
string[] strs = { "one", "two", "three" };

// String Length
Console.WriteLine(str1.Length);

// Getting individual char
Console.WriteLine(str1[14]);

// Intereate over a string like any other sequence of values
foreach (char ch in str1)
{
    Console.Write(ch);
    if (ch == 'b')
    {
        Console.WriteLine();
        break;
    }
}

// String concatenation
outstr = String.Concat(str1, str2);
Console.WriteLine(outstr);

// Joining strings
outstr = String.Join('.', strs);
Console.WriteLine(outstr);


// String comparions
/** Mostly used for sorting strings:
< 0 : first string comes before second
0 : strings are in the same position of order 
> 0 : first string comes after the second in sort order */
int result = string.Compare(str2, "This is a string");
Console.WriteLine("String comparison: " + result); // 0

// Is string equals
bool isEqual = str2.Equals("This is a string");
Console.WriteLine("Is equal?: " + isEqual); // 0 / False

// String searching
Console.WriteLine(str1.IndexOf("fox")); // 16
Console.WriteLine(str1.IndexOf("e")); // 2
Console.WriteLine(str1.LastIndexOf("e")); // 33

outstr = str1.Replace("fox", "cat");
Console.WriteLine(outstr); // The quick brown cat jumps over the lazy dog.