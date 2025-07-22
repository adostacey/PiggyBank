using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems;

public class DepositFunds : MenuItem
{
    public DepositFunds() : base("Deposit Funds") { }

    public override void Execute(Account account)
    {
        GetAmount();
        try
        {
            account.Deposit(Amount);
            GetBalance(account);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
