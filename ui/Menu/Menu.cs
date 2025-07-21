namespace PiggyBank.ui.Menu
{


    public class Menu
    {
        private readonly List<MenuItem> _menuItems = new();

        public void AddMenuItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MainMenu");

                for (int i = 0; i < _menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_menuItems[i].Title}");
                }
                Console.WriteLine("0. Exit");


                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                        break;

                    if (choice > 0 && choice <= _menuItems.Count)
                    {
                        Console.Clear();
                        _menuItems[choice].Execute();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");

                }

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
    }
}
