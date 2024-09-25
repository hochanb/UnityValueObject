using UnityEditor;

namespace ValueObjects
{
    [CustomEditor(typeof(ValueObject))]
    public class ValueObjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawPropertiesExcluding(serializedObject, "m_Script");
        }
    }
}