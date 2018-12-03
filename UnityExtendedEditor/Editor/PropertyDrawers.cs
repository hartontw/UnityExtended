using System;
using UnityEngine;
using UnityEditor;

namespace UnityExtended.Editor
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [CustomPropertyDrawer(typeof(Range<>))]
    public abstract class RangeDrawer<T> : PropertyDrawer
    {
        public const float CONTROL_HEIGHT = 16;
        public const float TOP_MARGIN = 3F;
        public const float BOTTOM_MARGIN = 3F;
        public const float LINE_HEIGHT = CONTROL_HEIGHT + 4F;

        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
        {
            return base.GetPropertyHeight(prop, label) + LINE_HEIGHT + TOP_MARGIN + BOTTOM_MARGIN;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            //EditorGUI.BeginProperty(position, label, property);            

            EditorGUI.DrawRect(position, Color.white * 0.70f);

            Rect rectLabel = new Rect(position.x, position.y + 3F, position.width, position.height);
            EditorGUI.PrefixLabel(rectLabel, GUIUtility.GetControlID(FocusType.Passive), label);            

            const float labelWidth = 30F;
            const float fieldWidth = 100F;
            const float sep = 10F;

            Rect minLabel = new Rect(position.x, position.y + TOP_MARGIN + LINE_HEIGHT, labelWidth, CONTROL_HEIGHT);
            Rect minField = new Rect(position.x + labelWidth, position.y + TOP_MARGIN + LINE_HEIGHT, fieldWidth, CONTROL_HEIGHT);
            Rect maxLabel = new Rect(position.x + labelWidth + fieldWidth + sep, position.y + TOP_MARGIN + LINE_HEIGHT, labelWidth, CONTROL_HEIGHT);
            Rect maxField = new Rect(position.x + labelWidth * 2F + fieldWidth + sep, position.y + TOP_MARGIN + LINE_HEIGHT, fieldWidth, CONTROL_HEIGHT);

            SerializedProperty min = property.FindPropertyRelative("min");
            SerializedProperty max = property.FindPropertyRelative("max");

            EditorGUI.LabelField(minLabel, "Min");
            EditorGUI.PropertyField(minField, min, GUIContent.none);

            EditorGUI.LabelField(maxLabel, "Max");
            EditorGUI.PropertyField(maxField, max, GUIContent.none);

            //EditorGUI.EndProperty();
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
        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
        {
            return base.GetPropertyHeight(prop, label) + LINE_HEIGHT;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            base.OnGUI(position, property, label);

            Rect valueField = new Rect(position.x, position.y + TOP_MARGIN + LINE_HEIGHT * 2F, position.width, CONTROL_HEIGHT);

            SerializedProperty min = property.FindPropertyRelative("min");
            SerializedProperty max = property.FindPropertyRelative("max");
            SerializedProperty val = property.FindPropertyRelative("_value");

            PaintSlider(valueField, val, min, max);
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
            EditorGUI.IntSlider(position, value, min.intValue, max.intValue);
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
            EditorGUI.Slider(position, value, min.floatValue, max.floatValue);
        }
    }
}