using PiggyBank;

Account account1 = new() { Name = "Aaron", AccountType = AccountTypes.Checking };

Console.WriteLine($"Name: {account1.Name}");
Console.WriteLine($"Account Type: {account1.AccountType}");
Console.WriteLine($"Balance: {account1.Balance}");

account1.Deposit(300);
Console.WriteLine($"Balance: {account1.Balance}");

account1.WithDraw(50);
Console.WriteLine($"Balance: {account1.Balance}");
