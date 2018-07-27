using System;
using UnityEditor;
using UnityEngine;

namespace UnityExtended.Editor
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [CustomPropertyDrawer(typeof(Range<>))]
    public abstract class RangeDrawer<T> : PropertyDrawer
    {
        public const int CONTROL_HEIGHT = 16;

        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
        {
            return base.GetPropertyHeight(prop, label) + CONTROL_HEIGHT;
        }

        protected virtual void DrawHeader(ref Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            position = EditorGUI.IndentedRect(position);

            EditorGUI.indentLevel = 1;

            position.y += CONTROL_HEIGHT;
            position.width = 60;
            position.height = CONTROL_HEIGHT;
        }

        protected virtual void DrawAditional(ref Rect position, SerializedProperty property, GUIContent label) { }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            DrawHeader(ref position, property, label);

            EditorGUI.LabelField(new Rect(position.x, position.y, 50, position.height), "Min");

            position.x += 28;

            SerializedProperty min = property.FindPropertyRelative("min");
            EditorGUI.PropertyField(position, min, GUIContent.none);

            position.x += 60;

            EditorGUI.LabelField(new Rect(position.x, position.y, 50, position.height), "Max");

            position.x += 32;

            SerializedProperty max = property.FindPropertyRelative("max");
            EditorGUI.PropertyField(position, max, GUIContent.none);

            DrawAditional(ref position, property, label);

            EditorGUI.indentLevel = 0;

            EditorGUI.EndProperty();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [CustomPropertyDrawer(typeof(InterpolableRange<>))]
    public abstract class InterpolableRangeDrawer<T> : RangeDrawer<T> { }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [CustomPropertyDrawer(typeof(NumericRange<>))]
    public abstract class NumericRangeDrawer<T> : InterpolableRangeDrawer<T> { }

    /// <summary>
    /// 
    /// </summary>
    [CustomPropertyDrawer(typeof(NumericRange<int>))]
    [CustomPropertyDrawer(typeof(IntRange))]
    public class RangeIntDrawer : NumericRangeDrawer<int>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty min = property.FindPropertyRelative("min");
            SerializedProperty max = property.FindPropertyRelative("max");

            if (min.intValue > max.intValue)
            {
                max.intValue = min.intValue;
            }
            else if (max.intValue < min.intValue)
            {
                min.intValue = max.intValue;
            }

            base.OnGUI(position, property, label);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [CustomPropertyDrawer(typeof(NumericRange<float>))]
    [CustomPropertyDrawer(typeof(FloatRange))]
    public class FloatRangeDrawer : NumericRangeDrawer<float>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty min = property.FindPropertyRelative("min");
            SerializedProperty max = property.FindPropertyRelative("max");

            if (min.floatValue > max.floatValue)
            {
                max.floatValue = min.floatValue;
            }
            else if (max.floatValue < min.floatValue)
            {
                min.floatValue = max.floatValue;
            }

            base.OnGUI(position, property, label);
        }
    }

    [CustomPropertyDrawer(typeof(InterpolableRange<Color>))]
    [CustomPropertyDrawer(typeof(ColorRange))]
    public class RangeColorDrawer : InterpolableRangeDrawer<Color> { }

    [CustomPropertyDrawer(typeof(BoundedNumber<>))]
    public abstract class BoundedDrawer<T> : NumericRangeDrawer<T>
    {
        protected override void DrawAditional(ref Rect position, SerializedProperty property, GUIContent label)
        {
            position = EditorGUI.IndentedRect(position);

            EditorGUI.indentLevel = 2;

            position.y += CONTROL_HEIGHT;
            position.width = 60;
            position.height = CONTROL_HEIGHT;

            SerializedProperty min = property.FindPropertyRelative("min");
            SerializedProperty max = property.FindPropertyRelative("max");
            SerializedProperty val = property.FindPropertyRelative("_value");

            PaintSlider(position, val, min, max);
        }

        protected abstract void PaintSlider(Rect position, SerializedProperty value, SerializedProperty min, SerializedProperty max);
    }

    /// <summary>
    /// 
    /// </summary>
    [CustomPropertyDrawer(typeof(BoundedNumber<int>))]
    [CustomPropertyDrawer(typeof(BoundedInt))]
    public class BoundedIntDrawer : BoundedDrawer<int>
    {
        protected override void PaintSlider(Rect position, SerializedProperty value, SerializedProperty min, SerializedProperty max)
        {
            EditorGUI.IntSlider(position, value.intValue, min.intValue, max.intValue);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [CustomPropertyDrawer(typeof(BoundedNumber<float>))]
    [CustomPropertyDrawer(typeof(BoundedFloat))]
    public class BoundedFloatDrawer : BoundedDrawer<float>
    {
        protected override void PaintSlider(Rect position, SerializedProperty value, SerializedProperty min, SerializedProperty max)
        {
            EditorGUI.Slider(position, value.floatValue, min.floatValue, max.floatValue);
        }
    }
}