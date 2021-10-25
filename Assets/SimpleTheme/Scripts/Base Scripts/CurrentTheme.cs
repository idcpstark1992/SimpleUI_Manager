using UnityEngine;

public class CurrentTheme 
{
    public SelectableColorProperties ButtonSelectableColors { get; private set; }
    public SelectableColorProperties ToggleColorScheme { get; private set; }
    public UIColors Colors { get; private set; }
    public FontProperties HeaderFont { get; private set; }
    public FontProperties SubHeaderFont { get; private set; }
    public FontProperties LabelFont { get; private set; }
    public FontProperties BodyFont { get; private set; }

    public CurrentTheme (Theme _innertheme)
    {
        ButtonSelectableColors  = _innertheme.ButtonSelectableColors;
        ToggleColorScheme       = _innertheme.ToggleColorScheme;
        Colors                  = _innertheme.Colors;
        HeaderFont              = _innertheme.HeaderFont;
        SubHeaderFont           = _innertheme.SubHeaderFont;
        LabelFont               = _innertheme.LabelFont;
        BodyFont                = _innertheme.BodyFont;
    }
}

