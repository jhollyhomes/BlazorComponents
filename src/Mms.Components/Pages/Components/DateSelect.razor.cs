using Microsoft.AspNetCore.Components;

namespace Mms.Components.Pages.Components;

public partial class DateSelect
{
    [Parameter]
    public DateOnly InitialDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    private bool _visible = false;

    void ShowPopup() => _visible = true;
    void ClosePopup() => _visible = false;
    void TogglePopup() => _visible = !_visible;

    void DateChanged(int day)
    {

    }

    private int FirstDayOfMonth => new DateOnly(InitialDate.Year, InitialDate.Month, 1).Day;
    private int DaysInMonth => DateTime.DaysInMonth(InitialDate.Year, InitialDate.Month);
    private List<string> _daysOfWeek = new()
    { 
        "Su", 
        "Mo",
        "Tu",
        "We",
        "Th",
        "Fr",
        "Sa"
    };
}


