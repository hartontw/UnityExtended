using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for Vector ranges.
    /// </summary>
    [Serializable]
    public abstract class VectorRange<T> : InterpolableRange<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public VectorRange(T start, T end) : base(start, end) { }

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