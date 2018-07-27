using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        #region Vector2
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="deg"></param>
        /// <returns></returns>
        public static Vector2 Rotate(this Vector2 self, float deg)
        {
            float radians = deg * Mathf.Deg2Rad;
            float ca = Mathf.Cos(radians);
            float sa = Mathf.Sin(radians);
            return new Vector2(ca * self.x - sa * self.y, sa * self.x + ca * self.y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Vector3 ProjectOnPlane(this Vector2 self, Vector3 plane = default(Vector3))
        {
            Vector3 vector = new Vector3(self.x, self.y, 0F);

            if (plane == default(Vector3))
                return vector;

            return Vector3.ProjectOnPlane(vector, plane);
        }
        #endregion

        #region Vector3
        #endregion

        #region Vector4
        #endregion
    }
}
