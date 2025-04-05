namespace _6._Code_Challenge___Bank_Accounts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Account baseAccount = new Account("John", "Doe", 1000);
        Console.WriteLine(baseAccount);
        baseAccount.Deposit(500);
        Console.WriteLine(baseAccount);
        // baseAccount.Withdraw(1501); // Insufficient funds

        Console.WriteLine();

        CheckingAcct cAccount = new CheckingAcct("Mary", "Smith", 1000);
        Console.WriteLine(baseAccount);
        cAccount.Withdraw(1500); // Overdraft fee
        Console.WriteLine(cAccount);

        Console.WriteLine();

        SavingsAcct sAccount = new SavingsAcct("Jane", "Doe", 0.03m, 1000);
        sAccount.Withdraw(200); // Overdraft fee
        sAccount.Withdraw(200); // Overdraft fee
        sAccount.Withdraw(200); // Overdraft fee
        sAccount.ApplyInterest(); // Interest applied
        sAccount.Withdraw(200); // Overdraft fee
        Console.WriteLine(sAccount);
    }
}
