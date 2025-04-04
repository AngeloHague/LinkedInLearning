// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// int theVal = 50;
// int theVal = 5;
// int theVal = 0;
int theVal = 4;

// Standard if-else
if (theVal >= 25)
{
    Console.WriteLine("The value is greater than or equal to 25.");
}
else if (theVal == 0)
{
    Console.WriteLine("The value is 0.");
}
else
{
    Console.WriteLine("The value is NOT greater than or equal to 25.");
}

// Ternary operator
Console.WriteLine("The ternary op says the value is " + ((theVal >= 25) ? "greater than or equal to" : "less than") + " 25.");

// Switch statement
switch (theVal)
{
    case 0:
        Console.WriteLine("The value is 0.");
        break;
    case 1:
        Console.WriteLine("The value is 1.");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine("The value is 2, 3 or 4.");
        break;
    default:
        Console.WriteLine("The value is greater than or equal to 5.");
        break;
}