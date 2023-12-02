using Microsoft.AspNetCore.Components;

namespace Mms.Components.Library.Select;

public partial class MultiSelect
{
    [Parameter]
    public List<DropDownItem> items { get; set; } = default!;

    void Toggle(string key)
    {
        var item = items.FirstOrDefault(x => x.Key == key);
        if (item != null)
        {
            item.IsChecked = !item.IsChecked;
        }
    }
}