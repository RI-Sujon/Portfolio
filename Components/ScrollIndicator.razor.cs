using Microsoft.AspNetCore.Components;

namespace RabiulPortfolio.Components;

public partial class ScrollIndicator : ComponentBase
{
    [Parameter]
    public bool Hidden { get; set; }

    [Parameter]
    public EventCallback OnClick { get; set; }
}
