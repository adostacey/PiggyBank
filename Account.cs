namespace PiggyBank;

public class Account
{
    public required string Name { get; set; }
    public decimal Balance { get; private set; }
    public required AccountTypes AccountType { get; init; }

    public void Deposit(decimal amount)
    {
        ValidAmmount(amount);
        Balance += amount;
    }

    public void WithDraw(decimal amount)
    {
        ValidAmmount(amount);
        if (amount < Balance)
        {
            Balance -= amount;
        }

        else
        { throw new ArgumentException("Not Enough Funds In Account"); }
    }

    private static void ValidAmmount(decimal amount)
    {
        if (amount < 0)
        { throw new ArgumentException("Amount must not be negative"); }
    }
}
