using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateNewTheme 
{
    [MenuItem("SimpleUI/Create/NewTheme")]
    public static void CreateMyAsset()
    {
        Theme asset = ScriptableObject.CreateInstance<Theme>();

        AssetDatabase.CreateAsset(asset, "Assets/NewTheme.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}
