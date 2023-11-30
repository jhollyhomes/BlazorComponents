using Microsoft.AspNetCore.Components;

namespace Mms.Components.Pages.Components;

public partial class DateSelect
{
    [Parameter]
    public DateOnly InitialDate { get; set; }

    private bool _visible = false;

    void ShowPopup() => _visible = true;
    void ClosePopup() => _visible = false;
    void TogglePopup() => _visible = !_visible;
}
