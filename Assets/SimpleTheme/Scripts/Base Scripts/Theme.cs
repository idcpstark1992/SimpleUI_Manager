using UnityEngine;
public class Theme : ScriptableObject
{

    [Header("All your Buttons Colors")]
    public SelectableColorProperties ButtonSelectableColors;
    public SelectableColorProperties ToggleColorScheme;
    
    [Header("Color for Your Panels")]
    public UIColors Colors;

    [Header("Fonts")]
    public FontProperties HeaderFont;
    public FontProperties SubHeaderFont;
    public FontProperties LabelFont;
    public FontProperties BodyFont;
}

