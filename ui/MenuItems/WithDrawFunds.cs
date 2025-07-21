using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class WithdrawFunds : MenuItem
{
    public WithdrawFunds() : base("Withdraw Funds") { }

    public override void Execute()
    {
        Console.Write("Withdraw funds");
    }
}
