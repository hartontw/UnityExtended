using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static class Bezier
    {
        #region float
        public static float Lerp(float t, float p0, float p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static float Lerp(float t, float p0, float p1, float p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static float FirstDerivative(float t, float p0, float p1, float p2)
        {
            return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static float Lerp(float t, float p0, float p1, float p2, float p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static float FirstDerivative(float t, float p0, float p1, float p2, float p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static float Lerp(float t, params float[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return 0F;
                case 1: return points[0];
                default:
                    float[] subPoints = new float[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = HMath.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion

        #region Vector2
        public static Vector2 Lerp(float t, Vector2 p0, Vector2 p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static Vector2 Lerp(float t, Vector2 p0, Vector2 p1, Vector2 p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static Vector2 FirstDerivative(float t, Vector2 p0, Vector2 p1, Vector2 p2)
        {
            return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector2 Lerp(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static Vector2 FirstDerivative(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector2 Lerp(float t, params Vector2[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return Vector2.zero;
                case 1: return points[0];
                default:
                    Vector2[] subPoints = new Vector2[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = Vector2.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion

        #region Vector3
        public static Vector3 Lerp(float t, Vector3 p0, Vector3 p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static Vector3 Lerp(float t, Vector3 p0, Vector3 p1, Vector3 p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static Vector3 FirstDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2)
        {
            return 2F * ((p2 + p0) * t + p1 * t - p0);
            //return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector3 Lerp(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static Vector3 FirstDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector3 Lerp(float t, params Vector3[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return Vector3.zero;
                case 1: return points[0];
                case 2: return Vector3.Lerp(points[0], points[1], t);
                default:
                    Vector3[] subPoints = new Vector3[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = Vector3.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion

        #region Vector4
        public static Vector4 Lerp(float t, Vector4 p0, Vector4 p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static Vector4 Lerp(float t, Vector4 p0, Vector4 p1, Vector4 p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static Vector4 FirstDerivative(float t, Vector4 p0, Vector4 p1, Vector4 p2)
        {
            return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector4 Lerp(float t, Vector4 p0, Vector4 p1, Vector4 p2, Vector4 p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static Vector4 FirstDerivative(float t, Vector4 p0, Vector4 p1, Vector4 p2, Vector4 p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Vector4 Lerp(float t, params Vector4[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return Vector4.zero;
                case 1: return points[0];
                case 2: return Vector4.Lerp(points[0], points[1], t);
                default:
                    Vector4[] subPoints = new Vector4[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = Vector4.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion

        #region Color
        public static Color Lerp(float t, Color p0, Color p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static Color Lerp(float t, Color p0, Color p1, Color p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static Color FirstDerivative(float t, Color p0, Color p1, Color p2)
        {
            return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Color Lerp(float t, Color p0, Color p1, Color p2, Color p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static Color FirstDerivative(float t, Color p0, Color p1, Color p2, Color p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Color Lerp(float t, params Color[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return Color.black;
                case 1: return points[0];
                case 2: return Color.Lerp(points[0], points[1], t);
                default:
                    Color[] subPoints = new Color[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = Color.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion

        /*
        #region Quaternion
        public static Quaternion Lerp(float t, Quaternion p0, Quaternion p1)
        {
            return p0 + (p1 - p0) * HMath.Clamp01(t);
        }

        public static Quaternion Lerp(float t, Quaternion p0, Quaternion p1, Quaternion p2)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            return p2 * (t * t) - 2F * p1 * d * t + p0 * (d * d);
        }

        public static Quaternion FirstDerivative(float t, Quaternion p0, Quaternion p1, Quaternion p2)
        {
            return 2F * ((p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Quaternion Lerp(float t, Quaternion p0, Quaternion p1, Quaternion p2, Quaternion p3)
        {
            float d = 1F - t;
            float td3 = 3F * t * d;

            return p0 * (d * d * d) + p1 * (td3 * d) + p2 * (td3 * t) + p3 * (t * t * t);
        }

        public static Quaternion FirstDerivative(float t, Quaternion p0, Quaternion p1, Quaternion p2, Quaternion p3)
        {
            return 3F * ((p3 - 3F * p2 + 3F * p1 - p0) * (t * t) + 2F * (p2 - 2F * p1 + p0) * t + p1 - p0);
        }

        public static Quaternion Lerp(float t, params Quaternion[] points)
        {
            int n = points.Length;
            switch (n)
            {
                case 0: return Quaternion.identity;
                case 1: return points[0];
                case 2: return Quaternion.Lerp(points[0], points[1], t);
                default:
                    Quaternion[] subPoints = new Quaternion[n - 1];

                    for (int i = 0; i < subPoints.Length; i++)
                        subPoints[i] = Quaternion.Lerp(points[i], points[i + 1], t);

                    return Lerp(t, subPoints);
            }
        }
        #endregion
    */
    }
}