using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeManager : MonoBehaviour
{
    public static CurrentTheme _CurrentTheme { get; private set; }
    [SerializeField] private int DefaultTheme;

    private void Awake()
    {
        ChangeTheme(DefaultTheme);
    }
    [SerializeField] private List<Theme> AviableThemesList;
    public void ChangeTheme(int ThemeIndex)
    {
        CurrentTheme NewTheme = new CurrentTheme(AviableThemesList[ThemeIndex]);
        _CurrentTheme = NewTheme;
        Delegates.Register_OnChangeTheme?.Invoke();
    }
}
