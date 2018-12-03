using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for float bounded numbers.
    /// </summary>
    [Serializable]
    public class BoundedFloat : InterpolableBoundedNumber<float>
    {
        /// <summary>
        /// Creates the absolute range of float type.
        /// </summary>
        public BoundedFloat() : base(float.MinValue, float.MaxValue, 0F) { }

        /// <summary>
        /// Creates a new bounded float with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest float of the range.
        /// </param>
        /// <param name="max">
        /// The largest float of the range.
        /// </param>
        /// <remarks>
        /// The bounded value equals to min.
        /// </remarks>
        public BoundedFloat(float min, float max) : base(min, max) { }

        /// <summary>
        /// Creates a new bounded float with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest float of the range.
        /// </param>
        /// <param name="max">
        /// The largest float of the range.
        /// </param>
        /// <param name="value">
        /// The initial bounded value.
        /// </param>
        public BoundedFloat(float min, float max, float value) : base(min, max, value) { }

        /// <summary>
        /// Difference between max and min values.
        /// </summary>
        public override float Length { get { return max - min; } }

        /// <summary>
        /// Linearly interpolates between min and max by t.
        /// </summary>
        /// <param name="t">
        /// The interpolation value between 0f and 1f.
        /// </param>
        public override float Lerp(float t)
        {
            return Mathf.Lerp(min, max, t);
        }

        /// <summary>
        /// Returns value between 0f and 1f based on the current value.
        /// </summary>
        public override float InverseLerp()
        {
            return (Value - Min) / Length;
        }

        public static implicit operator string(BoundedFloat bounded) { return bounded.Value.ToString(); }
        public static implicit operator float(BoundedFloat bounded) { return bounded.Value; }
        public static BoundedFloat operator +(BoundedFloat bounded, float value) { return new BoundedFloat(bounded.min, bounded.max, bounded.Value + value); }
        public static BoundedFloat operator +(float value, BoundedFloat bounded) { return new BoundedFloat(bounded.min, bounded.max, bounded.Value + value); }
        public static BoundedFloat operator -(BoundedFloat bounded, float value) { return new BoundedFloat(bounded.min, bounded.max, bounded.Value - value); }
        public static BoundedFloat operator -(float value, BoundedFloat bounded) { return new BoundedFloat(bounded.min, bounded.max, bounded.Value - value); }
    }
}
