using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all bounded interpolable numbers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public abstract class InterpolableBoundedNumber<T> : BoundedNumber<T>, ILerp<T>
        where T : struct, IComparable, IComparable<T>
    {
        /// <summary>
        /// Creates a new bounded value with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        /// <remarks>
        /// The bounded value equals to min.
        /// </remarks>
        public InterpolableBoundedNumber(T min, T max) : base(min, max) { }

        /// <summary>
        /// Creates a new bounded value with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        /// <param name="value">
        /// The initial bounded value.
        /// </param>
        public InterpolableBoundedNumber(T min, T max, T value) : base(min, max, value) { }

        /// <summary>
        /// Difference between max and min values.
        /// </summary>
        public abstract T Length { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public abstract T Lerp(float t);

        // <summary>
        /// Interpolates between min and max by t.
        /// </summary>
        /// <param name="t">
        /// The interpolation value between 0f and 1f.
        /// </param>
        /// <param name="function">
        /// The interpolation function.
        /// </param>
        public T Lerp(float t, Func<float, float> function)
        {
            return Lerp(function(t));
        }

        /// <summary>
        /// Interpolates between min and max by t.
        /// </summary>
        /// <param name="t">
        /// The interpolation value between 0f and 1f.
        /// </param>
        /// <param name="function">
        /// The Easing function.
        /// </param>
        public T Lerp(float t, Easing.Functions function)
        {
            return Lerp(t, Easing.Get(function));
        }

        /// <summary>
        /// Returns a random value between min and max.
        /// </summary>
        public T Random { get { return Lerp(HRandom.Value); } }
    }
}