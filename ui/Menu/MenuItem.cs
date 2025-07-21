namespace PiggyBank.ui.Menu
{
    public abstract class MenuItem
    {
        public string Title { get; set; }

        protected MenuItem(string title)
        {
            Title = title;
        }

        public abstract void Execute();
    }
}
