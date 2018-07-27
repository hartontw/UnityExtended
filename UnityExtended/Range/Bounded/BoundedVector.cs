using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for Vector bounds.
    /// </summary>
    [Serializable]
    public abstract class BoundedVector<T> : InterpolableBoundedValue<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public BoundedVector(T start, T end) : base(start, end) { }

        /// <summary>
        /// 
        /// </summary>
        public abstract T Direction { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract float Distance { get; }
    }
}