using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class WithdrawFunds : MenuItem
{
    protected WithdrawFunds() : base("Withraw Funds") { }

    public override void Execute()
    {
        Console.Write("Withdraw funds");
    }
}
