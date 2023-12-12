namespace Mms.Components.Library.State;

public class ThemeState
{
    public ThemeState() 
    {
        BackgroundColour = "bg-red-100";
        PrimaryColour = "bg-blue-600";
        PrimaryLightColour = "bg-blue-100";
        PrimaryTextColour = "bg-gray-100";
    }

    public event Action? OnStateChange;
    public string BackgroundColour { get; private set; } = default!;
    public string PrimaryColour { get; private set; } = default!;
    public string PrimaryLightColour { get; private set; } = default!;
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
    public void SetPrimaryLightColour(string value)
    {
        PrimaryLightColour = value;
        NotifyStateChanged();
    }
    public void SetPrimaryTextColour(string value)
    {
        PrimaryTextColour = value;
        NotifyStateChanged();
    }
}
