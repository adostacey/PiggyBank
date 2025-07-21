using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class DepositFunds : MenuItem
{
    public DepositFunds() : base("Deposit Funds") { }

    public override void Execute()
    {
        Console.Write("Add some funds");
    }
}
