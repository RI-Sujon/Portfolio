using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace RabiulPortfolio.Pages;

public partial class Index : ComponentBase
{
    [Inject]
    private IJSRuntime JS { get; set; } = default!;

    private bool hideScrollIndicator;

    private readonly string[] sectionIds =
    {
        "home", "about", "skills", "experience", "projects", "academic-new", "achievements", "contact"
    };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("initScrollIndicatorObserver", DotNetObjectReference.Create(this));
        }
    }

    [JSInvokable]
    public void OnContactSectionVisible(bool isVisible)
    {
        hideScrollIndicator = isVisible;
        StateHasChanged();
    }

    private async Task ScrollToNextSection()
    {
        await JS.InvokeVoidAsync("scrollToNextSection", new object[] { sectionIds });
    }
}
