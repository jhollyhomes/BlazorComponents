namespace Mms.Components.State;

public class ThemeState
{
    public ThemeState() 
    {
        BackgroundColour = "bg-blue-100";
        PrimaryColour = "bg-blue-600";
        PrimaryTextColour = "bg-gray-100";
    }

    public event Action? OnStateChange;
    public string BackgroundColour { get; private set; } = default!;
    public string PrimaryColour { get; private set; } = default!;
    public string PrimaryTextColour { get; private set; } = default!;

    private void NotifyStateChanged() => OnStateChange?.Invoke();
    
    public void SetBackgroundColour(string value)
    {
        BackgroundColour = value;
        NotifyStateChanged();
    }
    public void SetPrimaryColour(string value)
    {
        PrimaryColour = value;
        NotifyStateChanged();
    }
    public void SetPrimaryTextColour(string value)
    {
        PrimaryTextColour = value;
        NotifyStateChanged();
    }
}
