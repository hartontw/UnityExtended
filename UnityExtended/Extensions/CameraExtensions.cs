using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        /// ...
        /// </summary>
        public static Vector3 WorldToSignedViewportPoint(this Camera self, Vector3 position)
        {
            return (self.WorldToViewportPoint(position) - Vector3.one * 0.5F) * 2F;
        }

        /// <summary>
        /// ...
        /// </summary>
        public static Vector3 SignedViewportPointToWorld(this Camera self, Vector3 point)
        {
            return self.ViewportToWorldPoint(point * 0.5F + Vector3.one * 0.5F);
        }
    }
}
