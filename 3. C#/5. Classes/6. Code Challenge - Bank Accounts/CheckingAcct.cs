namespace _6._Code_Challenge___Bank_Accounts;

class CheckingAcct : Account
{

    public CheckingAcct(string firstName, string lastName, decimal initialBalance)
        : base(firstName, lastName, initialBalance)
    {
    }



    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            Balance -= (amount + 35); // Overdraft fee
        }
        else
        {
            Balance -= amount; // Overdraft fee
        }
    }
}