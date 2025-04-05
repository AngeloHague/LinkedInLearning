namespace _6._Code_Challenge___Bank_Accounts;

class SavingsAcct : Account
{

    int _withdrawlCount;
    decimal _interestRate;
    public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal initialBalance)
        : base(firstName, lastName, initialBalance)
    {
        _withdrawlCount = 0;
        _interestRate = interestRate;
    }

    public int WithdrawlCount {
        get => _withdrawlCount;
    }

    public decimal InterestRate {
        get => _interestRate;
        set => _interestRate = value;
    }

    public void ApplyInterest() {
        if (Balance > 0) {
            decimal interest = Balance * InterestRate;
            Deposit(interest);
            Console.WriteLine($"Interest of {interest:C} has been applied to your account.");
        } else {
            Console.WriteLine("No interest applied. Balance is zero or negative.");
        }
    }

    public override void Withdraw(decimal amount)
    {
        // do base withdrawl method
        if (_withdrawlCount >= 3) {
            base.Withdraw(amount+2);
            Console.WriteLine("A $2 fee has been applied to your account for exceeding 3 withdrawls.");
        } else {
            base.Withdraw(amount);
        }
        _withdrawlCount++;
    }

    public override string ToString()
    {
        return $"{AccountOwner}'s account has a balance of {Balance:C}. {WithdrawlCount} withdrawls have been made. {3 - WithdrawlCount} withdrawls remaining before a fee is applied.";
    }
}