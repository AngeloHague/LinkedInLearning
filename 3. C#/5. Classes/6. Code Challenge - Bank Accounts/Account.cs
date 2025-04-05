namespace _6._Code_Challenge___Bank_Accounts;

class Account
{
    private decimal _balance;
    private string _accountOwner;

    public Account(string firstName, string lastName, decimal initialBalance)
    {
        _accountOwner = firstName + " " + lastName;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        _balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            // throw new ArgumentException("Withdrawal amount must be positive.");
            Console.WriteLine("Withdrawal amount must be positive.");
        }
        else
        {
            if (amount > _balance)
            {
                // throw new InvalidOperationException("Insufficient funds.");
                Console.WriteLine("Insufficient Funds.");
            }
            else
            {
                _balance -= amount;
            }
        }
    }

    public decimal Balance
    {
        get => _balance;
        protected set => _balance = value;
    }

    public string AccountOwner
    {
        get => _accountOwner;
    }

    public override string ToString()
    {
        return $"{_accountOwner}'s account has a balance of {_balance:C}.";
    }
}
