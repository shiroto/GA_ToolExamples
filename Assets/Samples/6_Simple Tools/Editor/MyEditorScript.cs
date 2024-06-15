using UnityEditor;
using UnityEngine;

public static class MyEditorScript
{
    [MenuItem("Tools/MyScript")]
    public static void ExecuteEditorScript()
    {
        Debug.Log("My editor script was executed! Amazing!");
    }
}