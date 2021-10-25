using UnityEngine;


[AddComponentMenu("Simple UI/ColorChangerSubscriber")]
public class ChangerColorSubscriber : ChangerSubscriberBase
{
    [SerializeField] private ColorType color_Types;
    [SerializeField] private UnityEngine.UI.Image LocalImage;
    private void Awake()
    {
        FetchElementComponentToChange();
    }
    private void Start()
    {
        GetActiveFontFromThemeManager();
    }
    private void FetchElementComponentToChange()
    {
        if (gameObject.TryGetComponent(out UnityEngine.UI.Image outImage))
        {
            LocalImage = outImage;
        }
        else
        {
            Debug.LogError("There is not a ImageUI Component Attached to GameObject");
        }
    }

    public override void OnEnabledObject()
    {
        FetchElementComponentToChange();
        GetActiveFontFromThemeManager();
    }
    public override void OnChangedTheme()
    {
        GetActiveFontFromThemeManager();
    }
    private void GetActiveFontFromThemeManager()
    {
        switch (color_Types)
        {
            case ColorType.FlyoutColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.FlyoutColor);
                break;
            case ColorType.FlyoutColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.FlyoutColor_Alternative);
                break;
            case ColorType.BackGroundColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.BackGroundColor);
                break;
            case ColorType.BackGroundColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.BackGroundColor_Alternative);
                break;
            case ColorType.ForeGroundColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.ForeGroundColor);
                break;
            case ColorType.ForeGroundColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.ForeGroundColor_Alternative);
                break;
            case ColorType.OutLineColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.OutLineColor);
                break;
            case ColorType.OutLineColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.OutLineColor_Alternative);
                break;
            case ColorType.PanelColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.PanelColor);
                break;
            case ColorType.PanelColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.PanelColor_Alternative);
                break;
            case ColorType.EmphasisColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.EmphasisColor);
                break;
            case ColorType.EmphasisColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.EmphasisColor_Alternative);
                break;
            case ColorType.BackGroundSceneColor:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.BackGroundSceneColor);
                break;
            case ColorType.BackGroundSceneColor_Alternative:
                ConfigureColors(ThemeManager._CurrentTheme.Colors.BackGroundSceneColor_Alternative);
                break;
            default:
                break;
        }
    }
    private void ConfigureColors(Color _NewProperties)
    {
        LocalImage.color = _NewProperties;
    }
}
