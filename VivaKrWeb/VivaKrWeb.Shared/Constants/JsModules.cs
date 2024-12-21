namespace VivaKrWeb.Shared.Constants;

public static class JsModules
{
    private const string ContentRoot = "./_content/VivaKrWeb.Shared";
    private const string PagesRoot = $"{ContentRoot}/Pages";

    public static class ModulePath
    {
        public const string Code = $"{PagesRoot}/Code/Code.razor.js";
        public const string Home = $"{PagesRoot}/Home/Home.razor.js";
        public const string Profile = $"{PagesRoot}/Profile/Profile.razor.js";
        public const string Search = $"{PagesRoot}/Search/Search.razor.js";
        public const string Settings = $"{PagesRoot}/Settings/Settings.razor.js";
    }
}
