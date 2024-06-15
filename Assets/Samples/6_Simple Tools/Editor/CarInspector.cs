using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomEditor(typeof(Car))]
public class CarInspector : Editor
{
    public VisualTreeAsset inspectorXML;

    public override VisualElement CreateInspectorGUI()
    {
        // Create a new VisualElement to be the root of our Inspector UI.
        VisualElement myInspector = new VisualElement();

        // Add a simple label.
        myInspector.Add(new Label("This a script."));

        // Load from default reference.
        inspectorXML.CloneTree(myInspector);

        // Return the finished Inspector UI.
        return myInspector;
    }
}