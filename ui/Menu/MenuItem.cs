namespace PiggyBank.ui.Menu
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        protected int Amount { get; private set; }

        protected MenuItem(string title)
        {
            Title = title;
        }

        public void GetAmount()
        {
            Console.Write("Enter an amount: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    Amount = amount;
                    return;
                }
                else
                {
                    Console.Write("Please enter a valid amount: ");
                }
            }
        }

        public void GetBalance(Account account)
        {
            string formattedString = string.Format("{0:C}", account.Balance);
            Console.WriteLine($"Your balance is {formattedString}");
        }

        public abstract void Execute(Account account);
    }
}
