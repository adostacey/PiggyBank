using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class WithdrawFunds : MenuItem
{
    public WithdrawFunds() : base("Withdraw Funds") { }

    public override void Execute(Account account)
    {
        GetAmount();
        account.WithDraw(Amount);
        Console.Write($"Your account balance is: {account.Balance}");

    }
}
