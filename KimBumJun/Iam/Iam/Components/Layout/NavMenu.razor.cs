namespace Iam.Components.Layout;

public partial class NavMenu
{
    public string Title { get; set; } = "IAM";
    public List<MenuItem> NavMenuItems { get; set; }

    public NavMenu()
    {
        MenuItem menuItem = new();
        NavMenuItems = [
            new MenuItem { Icon="menu", Title = "Home", Url = "/" },
            new MenuItem { Icon="menu", Title = "Create", Url = "data/create" },
            new MenuItem { Icon="menu", Title = "자바스크립트", Url = "playjs" },
            new MenuItem { Icon="menu", Title = "데모", Url = "demo" },
            new MenuItem { Icon="menu", Title = "코드조각", Url = "code" },
            new MenuItem { Icon="chat", Title = "능선따라", Url = "chat" },
            new MenuItem { Icon="menu", Title = "카타로그", Url = "gamecatalog" },
            new MenuItem { Icon="menu", Title = "Counter", Url = "counter" },
            new MenuItem { Icon="chat", Title = "Weather", Url = "weather" }
        ];
    }
}

public class MenuItem
{
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
}
