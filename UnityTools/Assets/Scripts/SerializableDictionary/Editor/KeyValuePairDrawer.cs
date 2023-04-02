using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SKeyValuePair<,>))]
public class KeyValuePairDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		SerializedProperty _key = property.FindPropertyRelative("key");
		SerializedProperty _value = property.FindPropertyRelative("value");

		float _spacing = EditorGUIUtility.standardVerticalSpacing;
		float _width = position.width / 2.0f - _spacing / 2.0f;

		Rect _keyRect = new Rect(position.x, position.y, _width, EditorGUI.GetPropertyHeight(_key));
		Rect _valueRect = new Rect(position.x + _width + _spacing, position.y, _width, EditorGUI.GetPropertyHeight(_key));
		
		EditorGUI.BeginProperty(position, GUIContent.none, property);
		DrawProperty(_keyRect, _key);
		DrawProperty(_valueRect, _value);
		EditorGUI.EndProperty();
	}

	private static void DrawProperty(Rect position, SerializedProperty property)
	{
		if (property.propertyType.Equals(SerializedPropertyType.Generic)) DrawGenericProperty(position, property);
		else DrawBaseProperty(position, property);
	}

	private static void DrawGenericProperty(Rect position, SerializedProperty property)
	{
		Rect _propRect = new Rect(position.x + EditorGUIUtility.singleLineHeight - EditorGUIUtility.standardVerticalSpacing, position.y, position.width - EditorGUIUtility.singleLineHeight, position.height);
		EditorGUI.PropertyField(_propRect, property, new GUIContent(property.type), true);
	}

	private static void DrawBaseProperty(Rect position, SerializedProperty property)
	{
		EditorGUI.PropertyField(position, property, GUIContent.none);
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		float _keyHeight = EditorGUI.GetPropertyHeight(property.FindPropertyRelative("key"));
		float _valueHeight = EditorGUI.GetPropertyHeight(property.FindPropertyRelative("value"));
		return _keyHeight > _valueHeight ? _keyHeight : _valueHeight;
	}
}
