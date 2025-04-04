
// int x = 1000;
int x = 10000;
int y = 0;
int result;

try
{
    if (x > 1000) {
        throw new ArgumentOutOfRangeException("x is too large!"); // This line will not be executed
    }
    result = x / y;
    Console.WriteLine($"Result: {result}"); // This line will not be executed due to the exception
}
catch (Exception e)
{
    Console.WriteLine($"ERROR: Failed to divide."); // This line will be executed
    Console.WriteLine($"Exception: {e.Message}"); // This line will be executed
}
finally {
    Console.WriteLine("This will always be executed."); // This line will always be executed
}