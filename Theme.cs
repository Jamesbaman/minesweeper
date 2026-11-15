using Raylib_cs;

namespace MarkAndSweep;

/// <summary>All colours in one place so the look is easy to tweak.</summary>
public static class Theme
{
    public static readonly Color Background = new(192, 192, 192, 255);
    public static readonly Color Toolbar = new(60, 63, 70, 255);
    public static readonly Color Button = new(88, 92, 102, 255);
    public static readonly Color ButtonHover = new(110, 115, 128, 255);
    public static readonly Color ButtonActive = new(52, 120, 200, 255);
    public static readonly Color Border = new(30, 32, 36, 255);

    public static readonly Color BevelLight = new(255, 255, 255, 255);
    public static readonly Color BevelDark = new(123, 123, 123, 255);

    public static readonly Color HiddenCell = new(192, 192, 192, 255);
    public static readonly Color HoverCell = new(210, 210, 210, 255);
    public static readonly Color RevealedCell = new(222, 222, 222, 255);
    public static readonly Color CellGrid = new(150, 150, 150, 255);
    public static readonly Color ExplodedCell = new(230, 60, 60, 255);

    public static readonly Color Black = new(0, 0, 0, 255);
    public static readonly Color White = new(255, 255, 255, 255);
    public static readonly Color Red = new(220, 30, 30, 255);
    public static readonly Color Yellow = new(255, 215, 0, 255);

    public static readonly Color DisplayBackground = new(20, 0, 0, 255);
    public static readonly Color DisplayText = new(255, 40, 40, 255);

    public static readonly Color Text = new(30, 30, 30, 255);
    public static readonly Color TextDim = new(90, 90, 90, 255);
    public static readonly Color Win = new(20, 130, 40, 255);
    public static readonly Color Lose = new(190, 30, 30, 255);

    /// <summary>Classic number colours; index = number of adjacent mines (0 unused).</summary>
    public static readonly Color[] NumberColors =
    {
        new(0, 0, 0, 255),
        new(0, 0, 255, 255),
        new(0, 128, 0, 255),
        new(255, 0, 0, 255),
        new(0, 0, 128, 255),
        new(128, 0, 0, 255),
        new(0, 128, 128, 255),
        new(0, 0, 0, 255),
        new(128, 128, 128, 255)
    };
}
