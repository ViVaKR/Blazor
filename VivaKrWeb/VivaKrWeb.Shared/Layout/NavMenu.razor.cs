namespace VivaKrWeb.Shared.Layout;

public partial class NavMenu
{

    public record MenuItem(string Text, string Icon, string Url, string Roles);
    public required List<MenuItem> MenuItems { get; set; }

    protected override void OnInitialized()
    {
        MenuItems =
        [
            new MenuItem("Home", "house", "/", "Admin,User"),
            new MenuItem("Dashboard", "menu", "/Dashboard/Dashboard", "Admin,User"),
            new MenuItem("Code", "menu", "/Code/Code", "Admin"),
            new MenuItem("Camp", "menu", "/Camp/Camp", "Admin"),
            new MenuItem("Weather", "menu", "/weather", "Admin,User"),
            new MenuItem("Counter", "menu", "/counter", "Admin")
        ];
    }
}


