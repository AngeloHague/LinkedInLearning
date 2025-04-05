// C# code​​​​​​‌‌​‌​​​‌​‌​‌‌‌​​​​​​‌​​​‌ below
using System;
using System.Text;

// Determine whether a string is a Palindrome
static bool IsPalindrome(string thestr) {
    thestr = thestr.ToLower();
    foreach (char c in thestr){
        if (char.IsPunctuation(c) || char.IsWhiteSpace(c)) {
            thestr = thestr.Replace(c.ToString(), "");
        }
    };
    char[] charArray;
    charArray = thestr.ToCharArray();
    Array.Reverse(charArray);
    Console.WriteLine($"'{thestr}' vs {charArray.ToString()}");
    for (int i = 0; i < charArray.Length; i++) {
        if (thestr[i] != charArray[i]) {
            return false;
        }
    }
    return true;
}

string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
int palcount = 0;
foreach (string str in teststrings) {
	bool learnerResult = IsPalindrome(str);
	if (learnerResult)
		palcount++;
}Console.WriteLine($"There are {palcount} palindromes in the test strings.");