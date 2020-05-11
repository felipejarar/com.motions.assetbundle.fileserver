using UnityEditor;
using UnityEngine;

public class AssetBundlesBuilderTool
{
    readonly static float _Window_minWidth  = 500;
    readonly static float _Window_minHeight = 500;

    [MenuItem("Assets/Build AssetBundles")]
    static void init(){
        AssetBundlesBuilderTools_Window window = ScriptableObject.CreateInstance<AssetBundlesBuilderTools_Window>();
        window.position = new Rect(Screen.width / 6, Screen.height / 3, _Window_minWidth, _Window_minHeight);
        window.minSize = new Vector2(_Window_minWidth, _Window_minHeight);
        window.titleContent = new GUIContent("AssetBundles Builder Tool");
        window.ShowAuxWindow();
    }
}
