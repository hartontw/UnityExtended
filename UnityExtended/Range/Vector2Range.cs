using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for Vector2 ranges.
    /// </summary>
    [Serializable]
    public class Vector2Range : VectorRange<Vector2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public Vector2Range(Vector2 start, Vector2 end) : base(start, end) { }

        /// <summary>
        /// 
        /// </summary>
        public override Vector2 Direction { get { return max - min; } }

        /// <summary>
        /// 
        /// </summary>
        public override float Distance { get { return Direction.magnitude; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override Vector2 Lerp(float t)
        {
            return Vector2.Lerp(min, max, t);
        }
    }
}