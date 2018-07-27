﻿using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all bounded interpolable values.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public abstract class InterpolableBoundedValue<T> : BoundedValue<T>, ILerp<T>
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
        public InterpolableBoundedValue(T min, T max) : base(min, max) { }

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
        public InterpolableBoundedValue(T min, T max, T value) : base(min, max, value) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public abstract T Lerp(float t);

        /// <summary>
        /// Returns a random value between min and max.
        /// </summary>
        public T Random { get { return Lerp(HRandom.Value); } }
    }
}