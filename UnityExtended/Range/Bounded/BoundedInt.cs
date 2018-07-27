using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for integer bounded numbers.
    /// </summary>
    [Serializable]
    public class BoundedInt : InterpolableBoundedNumber<int>
    {
        /// <summary>
        /// Creates the absolute range of int type.
        /// </summary>
        public BoundedInt() : base(int.MinValue, int.MaxValue, 0) { }

        /// <summary>
        /// Creates a new bounded integer with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest integer of the range.
        /// </param>
        /// <param name="max">
        /// The largest integer of the range.
        /// </param>
        /// <remarks>
        /// The bounded value equals to min.
        /// </remarks>
        public BoundedInt(int min, int max) : base(min, max) { }

        /// <summary>
        /// Creates a new bounded integer with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest integer of the range.
        /// </param>
        /// <param name="max">
        /// The largest integer of the range.
        /// </param>
        /// <param name="value">
        /// The initial bounded value.
        /// </param>
        public BoundedInt(int min, int max, int value) : base(min, max, value) { }

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
            return Mathf.FloorToInt(Mathf.Lerp(min, max, t));
        }

        public static implicit operator string(BoundedInt bounded) { return bounded.Value.ToString(); }
        public static implicit operator int(BoundedInt bounded) { return bounded.Value; }
        public static BoundedInt operator +(BoundedInt bounded, int value) { return new BoundedInt(bounded.min, bounded.max, bounded.Value + value); }
    }
}
