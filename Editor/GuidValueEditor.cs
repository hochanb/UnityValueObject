using UnityEditor;
using UnityEngine;


namespace ValueObjects
{
    [CustomEditor(typeof(GuidValue))]
    public class GuidValueEditor : ValueObjectEditor
    {
        public override void OnInspectorGUI()
        {
            // Get the target object (GuidValue)
            var guidValue = target as GuidValue;

            GUI.enabled = false;

            EditorGUILayout.TextField("Value", guidValue.Value.ToString());

            GUI.enabled = true;
        }
    }
}