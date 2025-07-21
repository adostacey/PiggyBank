using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class CheckBalance : MenuItem
{
    protected CheckBalance() : base("Check Balance") { }

    public override void Execute()
    {
        Console.Write("This is your balance.");
    }
}
