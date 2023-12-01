namespace Mms.Components.Pages.Components.Select;

public class DropDownItem(string key, string value)
{
    public string Key { get; set; } = key;
    public string Value { get; set; } = value;
    public bool IsChecked { get; set; } = true;
}
