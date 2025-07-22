using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class WithdrawFunds : MenuItem
{
    public WithdrawFunds() : base("Withdraw Funds") { }

    public override void Execute(Account account)
    {
        GetAmount();
        try
        {
            account.WithDraw(Amount);
            Console.WriteLine($"Your account balance is: {account.Balance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
