using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for bounded Vector4.
    /// </summary>
    [Serializable]
    public class BoundedColor : InterpolableBoundedValue<Color>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public BoundedColor(Color start, Color end) : base(start, end) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override Color Lerp(float t)
        {
            return Color.Lerp(min, max, t);
        }
    }
}
