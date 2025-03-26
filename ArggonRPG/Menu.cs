namespace ArggonRPG;

public class Menu
{
    private static readonly List<Menu> Menus = [];
    
    public Menu(string title, List<MenuOptions> options)
    {
        Title = title;
        Options = options;
    }

    public short Id { get; set; }
    public string Title { get; set; }
    public List<MenuOptions> Options { get; set; }
    
    public static void CreateMenu(string title, List<MenuOptions> options)
    {
        var menu = new Menu(title, options)
        {
            Id = (short) (Menus.Count + 1)
        };
        Menus.Add(menu);
    }
    
    public static Menu GetMenu(string title)
    {
        return Menus.FirstOrDefault(x => x.Title == title) ?? new Menu(string.Empty, []);
    }

    public static List<Menu> GetAllMenus()
    {
        return Menus;
    }
    
    public static int SelectOption(Menu menu)
    {
        Console.WriteLine($"{menu.Title}");
        menu.Options.ForEach(option => Console.WriteLine($"{option.Id} - {option.Description}"));
        Console.WriteLine("Selecciona una opción:");
        return GetValidSelection(menu.Options.Count);
    }
    
    private static int GetValidSelection(int numberOfOptions)
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var choice) && choice > 0 && choice <= numberOfOptions)
            {
                return choice;
            }
            Console.WriteLine("Opción no válida. Intente de nuevo.");
        }
    }
}