using System;

namespace UnityExtended
{
    /// <summary>
    /// Class for float ranges.
    /// </summary>
    [Serializable]
    public class FloatRange : InterpolableNumericRange<float>
    {
        /// <summary>
        /// Creates the absolute range of float type.
        /// </summary>
        public FloatRange() : base(float.MinValue, float.MaxValue) { }

        /// <summary>
        /// Creates a new float range with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest float of the range.
        /// </param>
        /// <param name="max">
        /// The largest float of the range.
        /// </param>
        public FloatRange(float min, float max) : base(min, max) { }

        /// <summary>
        /// Creates a new float range with the given range.
        /// </summary>
        public FloatRange(IRange<float> range) : base(range.Min, range.Max) { }

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
            return HMath.Lerp(min, max, t);
        }
    }
}
