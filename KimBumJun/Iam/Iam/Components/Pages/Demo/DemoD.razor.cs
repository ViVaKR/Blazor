using Microsoft.AspNetCore.Components;

namespace Iam.Components.Pages.Demo;

public partial class DemoD
{
    [Parameter]
    public string? Name { get; set; }

    protected override void OnInitialized()
    {
        Name = "DemoD";
    }
}
