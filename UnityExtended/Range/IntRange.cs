using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for integer ranges.
    /// </summary>
    [Serializable]
    public class IntRange : InterpolableNumericRange<int>
    {
        /// <summary>
        /// Creates the absolute range of integer type.
        /// </summary>
        public IntRange() : base(int.MinValue, int.MaxValue) { }

        /// <summary>
        /// Creates a new integer range with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest integer of the range.
        /// </param>
        /// <param name="max">
        /// The largest integer of the range.
        /// </param>
        public IntRange(int min, int max) : base(min, max) { }

        /// <summary>
        /// Creates a new integer range with the given range.
        /// </summary>
        public IntRange(IRange<int> range) : base(range.Min, range.Max) { }

        /// <summary>
        /// Difference between max and min values.
        /// </summary>
        public override int Length { get { return max - min; } }

        /// <summary>
        /// Linearly interpolates between min and max by t.
        /// </summary>
        /// <param name="t">
        /// The interpolation value between 0f and 1f.
        /// </param>
        public override int Lerp(float t)
        {
            return HMath.FloorToInt(HMath.Lerp(min, max, t));
        }
    }
}
