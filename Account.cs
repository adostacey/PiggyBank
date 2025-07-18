namespace PiggyBank;

public class Account
{

    public required string Name { get; set; }
    public decimal Balance { get; private set; }
    public required AccountTypes AccountType { get; init; }

    public void Deposit(decimal amount)
    { Balance += amount; }

    public void WithDraw(decimal amount)
    { Balance -= amount; }

}
