using UnityEngine;

public class ChangerToggleSubscriber : ChangerSubscriberBase
{
    [SerializeField] UnityEngine.UI.Toggle LocalToggle;
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
        if (gameObject.TryGetComponent(out UnityEngine.UI.Toggle OutToggle))
        {
            LocalToggle = OutToggle;
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
        ConfigureFont(ThemeManager._CurrentTheme.ToggleColorScheme.SelectableColorScheme);
    }
    private void ConfigureFont(UnityEngine.UI.ColorBlock _NewProperties)
    {
        LocalToggle.colors = _NewProperties;
    }
}