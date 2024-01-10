using Microsoft.AspNetCore.Components;
using Mms.Components.Library.State;

namespace Mms.Components.Library.Select;

public partial class MultiSelect
{
    [CascadingParameter]
    protected ThemeState ThemeState { get; set; } = default!;

    [Parameter]
    public List<DropDownItem> items { get; set; } = default!;

    private const int MAX_ITEMS_TO_DISPLAY = 3;

    private bool _dropdownVisible = false;

    private void Toggle(string key)
    {
        var item = items.FirstOrDefault(x => x.Key == key);
        if (item != null)
        {
            item.IsChecked = !item.IsChecked;
        }
    }

    private void ClosePopup()
    {
        _dropdownVisible = false;
    }

    private void TogglePopup() => _dropdownVisible = !_dropdownVisible;
}