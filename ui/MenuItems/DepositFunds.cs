using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class DepositFunds : MenuItem
{
    protected DepositFunds() : base("Check Balance") { }

    public override void Execute()
    {
        Console.Write("Add some funds");
    }
}
