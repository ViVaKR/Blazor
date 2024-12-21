using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using VivaKrWeb.Shared.Constants;
namespace VivaKrWeb.Shared.Pages.Code;

public partial class Code : ComponentBase
{
    [Parameter]
    public string? Id { get; set; }

    public record AccordionData(string Title, string Target, string Content);

    [Inject]
    public IJSRuntime? Js { get; set; } = default!;

    private List<AccordionData> dataList = [];

    private string? statusParameter;

    [Inject]
    public NavigationManager? NavigationManager { get; set; } = default!;
    // 라이프사이클 메서드 ///////////////////////////////////////////////////////////////
    // (1) 컴포넌트 초기화 로직
    protected override void OnInitialized()
    {
        dataList = [
            new AccordionData("Item #1", "targetOne", "<strong class=\"text-yellow-700\">One</strong> content"),
            new AccordionData("Item #2", "targetTwo", "<strong class=\"text-sky-500\">Two</strong> content"),
            new AccordionData("Item #3", "targetThree", "<strong class=\"text-rose-500\">Three</strong> content"),
        ];
        base.OnInitialized();
    }

    // (2) 컴포넌트 렌더링 직후 로직
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Js != null)
        {
            // await Js.InvokeVoidAsync("initializePopovers");
            await Js.InvokeVoidAsync("console.log", "Code page rendered");
            var module = await Js.InvokeAsync<IJSObjectReference>("import", JsModules.ModulePath.Code);
            await module.InvokeVoidAsync("initialize");
        }
    }

    // (3) 매개변수 변경 시 로직
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        statusParameter = $"Updated at {DateTime.Now:HH:mm:ss}";
    }

    private async Task NavigateToPage(string page, int id)
    {
        NavigationManager?.NavigateTo($"{page}/{id}"); // 클라이언트 사이드 라우팅
        // NavigationManager?.NavigateTo($"{page}/{id}", forceLoad: true); // 서버 사이드 리로드
        await Task.CompletedTask;

    }
}

/*
--> `forceLoad`: true

 옵션의 장점 분석

1. **페이지 리로드 동작**
   - 전체 페이지를 새로 로드
   - 브라우저 캐시를 무시하고 새로운 데이터 로드
   - 상태 초기화 가능

2. **사용 케이스**
   - 인증 상태 변경 시
   - 캐시된 데이터 초기화 필요 시
   - 전체 앱 상태 리셋 필요 시

### 코드 예시

```csharp


// 1. 일반 네비게이션 (SPA 방식)
private void NavigateNormal(string page, int id)
{
    NavigationManager?.NavigateTo($"{page}/{id}");  // 클라이언트 사이드 라우팅
}

// 2. 강제 리로드 네비게이션
private void NavigateWithForceLoad(string page, int id)
{
    NavigationManager?.NavigateTo($"{page}/{id}", forceLoad: true);  // 서버 사이드 리로드
}
```

### 권장 사용 시나리오
- 로그아웃 처리
- 인증 토큰 갱신
- 앱 상태 전체 리셋
- 캐시 무효화 필요 시
 */
