using Microsoft.AspNetCore.Components;

namespace Mms.Components.Pages.Components;

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

public class DropDownItem(string key, string value)
{
    public string Key { get; set; } = key;
    public string Value { get; set; } = value;
    public bool IsChecked { get; set; } = true;
}