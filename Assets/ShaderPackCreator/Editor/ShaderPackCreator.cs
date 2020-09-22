using UnityEditor;
using System.IO;

public class CreateAssetBundles
{
    [MenuItem("VRM/Build Shader Packs")]
    static void BuildAllAssetBundles()
    {
        string shaderPacksDirectory = "Assets/ShaderPacks";
        if (!Directory.Exists(shaderPacksDirectory))
        {
            Directory.CreateDirectory(shaderPacksDirectory);
        }
        BuildPipeline.BuildAssetBundles(shaderPacksDirectory,
                                        BuildAssetBundleOptions.None,
                                        BuildTarget.StandaloneWindows);
    }
}