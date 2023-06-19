using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

[CustomEditor(typeof(TouchSimulatorToggle))]
public class TouchSimulatorToggleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Debug.Log("TouchSimulatorToogleEditor.OnInspectorGUI");
        DrawDefaultInspector();

        if (GUILayout.Button("Enable Touch Simulation"))
        {
            TouchSimulation.Enable();
        }

        if (GUILayout.Button("Disable Touch Simulation"))
        {
            TouchSimulation.Disable();
        }
    }
}
