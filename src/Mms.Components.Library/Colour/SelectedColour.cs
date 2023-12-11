namespace Mms.Components.Library.Colour;

public class SelectedColour
{
    public SelectedColour(string colour, string shade)
    {
        Colour = colour;
        Shade = shade;
    }
    public SelectedColour(string colour)
    {
        Colour = colour;
    }
    public string Colour { get; set; } = default!;
    public string Shade { get; set; } = default!;

    public string CreateColourCss(ColourTypes colourTypes)
    {
        if (Colour == "white")
        {
            return colourTypes switch
            {
                ColourTypes.Text => "text-white",
                ColourTypes.Background => "bg-white",
                ColourTypes.HoverBackground => "hover:bg-white",
                ColourTypes.HoverText => "hover:text-white",
                _ => string.Empty
            };
        }

        if (Colour == "black")
        {
            return colourTypes switch
            {
                ColourTypes.Text => "text-black",
                ColourTypes.Background => "bg-black",
                ColourTypes.HoverBackground => "hover:bg-black",
                ColourTypes.HoverText => "hover:text-black",
                _ => string.Empty
            };
        }

        return colourTypes switch
        {
            ColourTypes.Text => string.Concat("text-", Colour, "-", Shade),
            ColourTypes.Background => string.Concat("bg-", Colour, "-", Shade),
            ColourTypes.HoverBackground => string.Concat("hover:bg-", Colour, "-", Shade),
            ColourTypes.HoverText => string.Concat("hover:text-", Colour, "-", Shade),
            _ => string.Empty
        };
    }
}


