namespace Mms.Components.Pages.Components;

public partial class MultiSelect
{
    public List<DropDownItem> items { get; set; } = new();

    protected override void OnInitialized()
    {
        GetItems();
    }

    void GetItems()
    {
        items = new()
        {
            new DropDownItem("NS", "Not started"),
            new DropDownItem("IP", "In progress"),
            new DropDownItem("CO", "Completed"),
            new DropDownItem("CA", "Cancelled"),
            new DropDownItem("OH", "On hold"),
            new DropDownItem("RA", "Reassigned")
        };
    }

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