using Microsoft.JSInterop;

namespace VivaKrWeb.Shared.Services;

public class JSInteropService(IJSRuntime jsRuntime) : IJSInteropService
{
    private readonly IJSRuntime _jsRuntime = jsRuntime;

    public async Task InitializeBootstrapPlugins()
    {
        await _jsRuntime.InvokeVoidAsync("observeBootstrapElements");
    }
}
