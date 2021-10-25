using UnityEngine;

public class ChangerButtonSubscriber : ChangerSubscriberBase
{
    [SerializeField] UnityEngine.UI.Button LocalButton;
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
        if (gameObject.TryGetComponent(out UnityEngine.UI.Button OutButton))
        {
            LocalButton = OutButton;
        }
        else
        {
            Debug.LogError("There is not a Button Component Attached to GameObject");
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
        ConfigureFont(ThemeManager._CurrentTheme.ButtonSelectableColors.SelectableColorScheme);
    }
    private void ConfigureFont(UnityEngine.UI.ColorBlock _NewProperties)
    {
        LocalButton.colors = _NewProperties;
    }
}
