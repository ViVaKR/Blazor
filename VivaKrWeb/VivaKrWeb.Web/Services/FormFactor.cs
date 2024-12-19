using System.Text.Json;
using VivaKrWeb.Shared.Services;

namespace VivaKrWeb.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
