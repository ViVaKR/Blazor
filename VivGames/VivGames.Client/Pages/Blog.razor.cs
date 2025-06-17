using Microsoft.AspNetCore.Components;

namespace VivGames.Client.Pages;

public partial class Blog : ComponentBase
{
    private bool isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        await LoadDataAsync();
        isLoading = false;
    }

    private static Task LoadDataAsync()
    {
        return Task.Delay(5000);
    }
}
