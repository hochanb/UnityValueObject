using UnityEditor;
using UnityEngine;

namespace ValueObjects
{
    [CustomEditor(typeof(ValueObject))]
    public class ValueObjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawPropertiesExcluding(serializedObject, "m_Script");
            serializedObject.ApplyModifiedProperties();
        }
    }
    public class ValueObjectDrawer<T> : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Begin Property to ensure undo functionality, etc.
            EditorGUI.BeginProperty(position, label, property);
            
            float totalHeight = EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing * 3 + 5;
            
            Rect propertyRect = new Rect(position.x + 5, position.y + 5, position.width - 10, EditorGUIUtility.singleLineHeight);
            
            Rect previewRect = new Rect(position.x + 5, propertyRect.y + EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing, position.width - 10, EditorGUIUtility.singleLineHeight);
            
            // Get the actual object reference from the property
            var valueObject = property.objectReferenceValue as ValueObject<T>;
            SerializedObject serializedValueObject;
            SerializedProperty valueProperty = null;

            if (valueObject != null)
            {
                serializedValueObject = new SerializedObject(valueObject);
                valueProperty = serializedValueObject.FindProperty("_value");
                if (valueProperty != null)
                {
                    float propertyHeight = EditorGUI.GetPropertyHeight(valueProperty);
                    previewRect.height = propertyHeight;
                    totalHeight += propertyHeight;

                    // as it uses wide mode, reduce one line for property with height over one line
                    if (propertyHeight > EditorGUIUtility.singleLineHeight)
                        totalHeight -= EditorGUIUtility.singleLineHeight;   
                }
                else
                    // for label field
                    totalHeight += EditorGUIUtility.singleLineHeight;
            }


            // draw all after data fetching

            Rect boxRect = new Rect(position.x, position.y, position.width, totalHeight);
            GUI.Box(boxRect, GUIContent.none, EditorStyles.helpBox);

            EditorGUI.PropertyField(propertyRect, property, label);

            if (valueObject != null)
            {
                GUI.enabled = false;  // Make the text field readonly
                EditorGUIUtility.wideMode = true;
                if (valueProperty != null)
                    EditorGUI.PropertyField(previewRect, valueProperty, new GUIContent("value"));
                else
                    EditorGUI.TextField(previewRect, "value", valueObject.Value.ToString());
                
                GUI.enabled = true;
                EditorGUIUtility.wideMode = false;
            }
            EditorGUI.EndProperty();
        }



        // Override to ensure the drawer's height accounts for both the field and preview
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            // One line + property height + paddings
            var valueObject = property.objectReferenceValue as ValueObject<T>;
            SerializedObject serializedValueObject;
            SerializedProperty valueProperty = null;
            float h = EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing * 3 + 5;
            if (valueObject != null)
            {
                serializedValueObject = new SerializedObject(valueObject);
                valueProperty = serializedValueObject.FindProperty("_value");
                if (valueProperty != null)
                {
                    float propertyHeight = EditorGUI.GetPropertyHeight(valueProperty);
                    h += propertyHeight;

                    // as it uses wide mode, reduce one line for property with height over one line
                    if (propertyHeight > EditorGUIUtility.singleLineHeight)
                        h -= EditorGUIUtility.singleLineHeight;
                }
                else
                    // for label field
                    h += EditorGUIUtility.singleLineHeight;
            }
            return h;
        }
    }
}