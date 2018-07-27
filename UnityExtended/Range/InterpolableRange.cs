using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all interpolable ranges.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public abstract class InterpolableRange<T> : Range<T>, ILerp<T>
    {
        /// <summary>
        /// Creates a new range with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        public InterpolableRange(T min, T max) : base(min, max) { }

        /// <summary>
        /// Linearly interpolates between min and max by t.
        /// </summary>
        /// <param name="t">
        /// The interpolation value between 0f and 1f.
        /// </param>
        public abstract T Lerp(float t);

        /// <summary>
        /// Returns random value between min and max.
        /// </summary>
        public T Random { get { return Lerp(HRandom.Value); } }
    }
}