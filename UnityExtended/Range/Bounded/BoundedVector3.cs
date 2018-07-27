using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for bounded Vector3.
    /// </summary>
    [Serializable]
    public class BoundedVector3 : BoundedVector<Vector3>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public BoundedVector3(Vector3 start, Vector3 end) : base(start, end) { }

        /// <summary>
        /// 
        /// </summary>
        public override Vector3 Direction { get { return max - min; } }

        /// <summary>
        /// 
        /// </summary>
        public override float Distance { get { return Direction.magnitude; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override Vector3 Lerp(float t)
        {
            return Vector3.Lerp(min, max, t);
        }
    }
}