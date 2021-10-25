using UnityEngine;

public class ChangerTextSubscriber : ChangerSubscriberBase
{
    [SerializeField] private TMPro.TextMeshProUGUI LocalText;
    [SerializeField] private FontType font_Types;
    private void Awake()
    {
        FetchTextToChange();
    }
    private void Start()
    {
        GetActiveFontFromThemeManager();
    }
    private void FetchTextToChange()
    {
        if (gameObject.TryGetComponent(out TMPro.TextMeshProUGUI OuterTmpro))
        {
            LocalText = OuterTmpro;
        }
        else
        {
            Debug.LogError("There is not a TextMeshProUGUI Component Attached to GameObject");
        }
    }
    public override void OnEnabledObject()
    {
        FetchTextToChange();
        GetActiveFontFromThemeManager();
    }
    public override void OnChangedTheme()
    {
        GetActiveFontFromThemeManager();
    }
    private void GetActiveFontFromThemeManager()
    {
        switch (font_Types)
        {
            case FontType.Header:
                ConfigureFont(ThemeManager._CurrentTheme.HeaderFont);
                break;
            case FontType.SubHeader:
                ConfigureFont(ThemeManager._CurrentTheme.SubHeaderFont);
                break;
            case FontType.Label:
                ConfigureFont(ThemeManager._CurrentTheme.LabelFont);
                break;
            case FontType.Body:
                ConfigureFont(ThemeManager._CurrentTheme.BodyFont);
                break;
        }
    }
    private void ConfigureFont(FontProperties _NewProperties)
    {
        LocalText.font =        _NewProperties.Font_type;
        LocalText.fontSize =    _NewProperties.FontSize;
        LocalText.color =       _NewProperties.FontColor;
        LocalText.alignment =   _NewProperties.Alignement;
        LocalText.fontStyle =   _NewProperties.FontStyle;
    }
}
