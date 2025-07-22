using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class DepositFunds : MenuItem
{
    public DepositFunds() : base("Deposit Funds") { }

    public override void Execute(Account account)
    {
        GetAmount();
        account.Deposit(Amount);
        Console.Write($"Your account balance is: {account.Balance}");
    }
}
