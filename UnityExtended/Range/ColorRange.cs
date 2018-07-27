using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for Color ranges.
    /// </summary>
    [Serializable]
    public class ColorRange : InterpolableRange<Color>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public ColorRange(Color min, Color max) : base(min, max) { }

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
