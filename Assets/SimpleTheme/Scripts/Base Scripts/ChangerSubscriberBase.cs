using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangerSubscriberBase : MonoBehaviour
{
    [Header("Enable This Option If your Component shall be Created in RunTime")]
    [SerializeField] private bool EmergentElement;

    private void OnEnable()
    {
        Delegates.Register_OnChangeTheme += OnChangedTheme;
        if (EmergentElement)
            OnEnabledObject();
    }
    private void OnDisable()
    {
        Delegates.Register_OnChangeTheme -= OnChangedTheme;
       
    }
    public virtual void OnChangedTheme()
    {

    }
    public virtual void OnEnabledObject()
    {

    }
}
[System.Serializable]
enum FontType
{
    Header,
    SubHeader,
    Label,
    Body
}
[System.Serializable]
enum ColorType
{
    FlyoutColor,
    FlyoutColor_Alternative,
    BackGroundColor,
    BackGroundColor_Alternative,
    ForeGroundColor,
    ForeGroundColor_Alternative,
    OutLineColor,
    OutLineColor_Alternative,
    PanelColor,
    PanelColor_Alternative,
    EmphasisColor,
    EmphasisColor_Alternative,
    BackGroundSceneColor,
    BackGroundSceneColor_Alternative
}
