using PiggyBank;
using PiggyBank.ui.Menu;
using PiggyBank.ui.MenuItems;

Account account1 = new() { Name = "Aaron", AccountType = AccountTypes.Checking };

Menu menu = new();
menu.Account = account1;
menu.AddMenuItem(new CheckBalance());
menu.AddMenuItem(new DepositFunds());
menu.AddMenuItem(new WithdrawFunds());
menu.Show();
