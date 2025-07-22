using PiggyBank.ui.Menu;

namespace PiggyBank.ui.MenuItems
{
    public class CheckBalance : MenuItem
    {
        public CheckBalance() : base("Check Balance") { }

        public override void Execute(Account account)
        {
            GetBalance(account);
        }
    }
}
