using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary> タイプ別エフェクトエディター </summary>
public class EditorWindowSample : EditorWindow {

    private const string IconPath = "Assets/Resources/Icon/";

    private const string BurstEffectPrefabPath = "Assets/Resources/Prefabs/Effects/Burst/Effect_Burst.prefab";
    private const string TornadoEffectPrefabPath = "Assets/Resources/Prefabs/Effects/Tornado/Effect_Tornado.prefab";
    private const string RainEffectPrefabPath = "Assets/Resources/Prefabs/Effects/Rain/Effect_Rain.prefab";

    [MenuItem("Editor/EditorWindowSample")]
    private static void Create() {
        EditorWindowSample window = GetWindow<EditorWindowSample>("タイプ別エフェクトサンプル");
        window.minSize = new Vector2(512, 64);
        window.maxSize = new Vector2(512, 64);
    }
    
    private void OnGUI() {

        var iconFireWork = AssetDatabase.LoadAssetAtPath<Texture>(IconPath + "icon_fire_work.png");
        var iconTornado = AssetDatabase.LoadAssetAtPath<Texture>(IconPath + "icon_tornado.png");
        var iconRain = AssetDatabase.LoadAssetAtPath<Texture>(IconPath + "icon_rain.png");

        using (new GUILayout.HorizontalScope()) {
            
            // if (GUILayout.Button("「爆発」作成", GUILayout.Width(128), GUILayout.Height(64))) {
            //     CreateBurstEffectPrefab();
            // }
            
            // 爆発タイプのエフェクト作成
            if (GUILayout.Button(iconFireWork, GUILayout.Width(64), GUILayout.Height(64))) {
                CreateEffectPrefab(BurstEffectPrefabPath, "Effect_Burst");
            }
            
            // 竜巻タイプのエフェクト作成
            if (GUILayout.Button(iconTornado, GUILayout.Width(64), GUILayout.Height(64))) {
                CreateEffectPrefab(TornadoEffectPrefabPath, "Effect_Tornado");
            }
            
            // 雨タイプのエフェクト作成
            if (GUILayout.Button(iconRain, GUILayout.Width(64), GUILayout.Height(64))) {
                CreateEffectPrefab(RainEffectPrefabPath, "Effect_Rain");
            }
        }
    }
    
    /// <summary> エフェクトPrefab作成 </summary>
    private void CreateEffectPrefab(string prefabPath, string prefabName) {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        var go = Instantiate(prefab);
        go.name = prefabName;
    }
}
