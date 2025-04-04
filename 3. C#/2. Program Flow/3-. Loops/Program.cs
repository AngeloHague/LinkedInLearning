// Standard For Loop
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("For loop iteration: " + i);
}
Console.WriteLine();

int M = 4;
int n = M;

int[] nums = { 14, 22, 33, 41, 55, 66, 77, 88, 99 };
// For Each Loop
foreach (int num in nums)
{
    if (num == 55) { Console.WriteLine("Skipping this number because we don't like it: " + num); continue; }
    Console.WriteLine("For each loop iteration: " + num);
    if (num >= 50)
    {
        Console.WriteLine("Found a number >= 50, breaking loop: " + num);
        break; // Breaks out of the loop when num is greater than or equal to 50
    }
}
Console.WriteLine();

string str = "the brown dog jumped over the lazy fox";
int occurences = 0;
foreach (char c in str)
{
    if (c == 'o')
    {
        occurences++;
    }
}
Console.WriteLine($"The letter 'o' occurs {occurences} times in the string.");
Console.WriteLine();

// While Loops
string inputStr = "";
while (inputStr != "exit")
{
    Console.WriteLine("Enter a string (type 'exit' to quit): ");
    inputStr = Console.ReadLine();
    if (inputStr != "exit")
    {
        Console.WriteLine("You entered: " + inputStr);
    }
}
Console.WriteLine();



// Do-While Loops
do
{
    Console.WriteLine("Are you sure you want to exit? (type 'yes' to quit): ");
    inputStr = Console.ReadLine();
    if (inputStr != "yes")
    {
        Console.WriteLine("You entered: " + inputStr);
    }
}
while (inputStr != "yes");
Console.WriteLine();

