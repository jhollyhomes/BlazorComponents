namespace Mms.Components.Library.State;

public class ThemeState
{
    public ThemeState()
    {
        BackgroundColour = "bg-red-100";
        IconColour = "text-indigo-600";
        PrimaryLightColour = "bg-blue-100";
        PrimaryTextColour = "bg-gray-100";

        FormControlColour = "accent-indigo-600";
        ButtonColour = "bg-indigo-600";
        ButtonHoverColour = "bg-indigo-700";
        ButtonTextColour = "text-gray-50";
    }

    public event Action? OnStateChange;
    public string BackgroundColour { get; private set; } = default!;
    public string IconColour { get; private set; } = default!;
    public string PrimaryLightColour { get; private set; } = default!;
    public string PrimaryTextColour { get; private set; } = default!;
    public string FormControlColour { get; private set; } = default!;
    public string ButtonColour { get; private set; } = default!;
    public string ButtonHoverColour { get; private set; } = default!;
    public string ButtonTextColour { get; private set; } = default!;

    private void NotifyStateChanged() => OnStateChange?.Invoke();
    
    public void SetBackgroundColour(string value)
    {
        BackgroundColour = value;
        NotifyStateChanged();
    }
    public void SetIconColour(string value)
    {
        IconColour = value;
        NotifyStateChanged();
    }
    public void SetFormControlColour(string value)
    {
        FormControlColour = value;
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
    public void SetButtonColour(string value)
    {
        ButtonColour = value;
        NotifyStateChanged();
    }
    public void SetButtonHoverColour(string value)
    {
        ButtonHoverColour = value;
        NotifyStateChanged();
    }
    public void SetButtonTextColour(string value)
    {
        ButtonTextColour = value;
        NotifyStateChanged();
    }
}
