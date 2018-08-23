using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static class Bezier
    {
        #region float
        public static float Lerp(float t, params float[] points)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            int n = points.Length;
            switch (n)
            {
                case 0: return 0F;

                case 1: return points[0];

                case 2: return points[0] * d + points[1] * t;

                case 3: return points[0] * d * d + 2F * points[1] * d * t + points[2] * t * t;

                case 4:
                    float td3 = 3F * t * d;
                    return points[0] * d * d * d + points[1] * td3 * d + points[2] * td3 * t + points[3] * t * t * t;

                default:
                    n--;

                    float pt = 1F;

                    float add = 0F;

                    for (int i = 0; i <= n; i++, pt *= t)
                        add += HMath.Combinations(n, i) * points[i] * HMath.Pow(d, n - i) * pt;

                    return add;
            }
        }

        public static float FirstDerivative(float t, params float[] points)
        {
            t = HMath.Clamp01(t);

            if (t == 1F) return 0F;

            int n = points.Length;
            switch (n)
            {
                case 0:
                case 1:
                    return 0F;

                case 2: return points[1] - points[0];

                case 3: return 2F * ((points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                case 4:
                    return 3F * ((points[3] - 3F * points[2] + 3F * points[1] - points[0]) * (t * t)
                    + 2F * (points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                default:
                    n--;

                    float combination, d = 1F - t;

                    float add = points[0] * (-n * HMath.Pow(d, n - 1));

                    for (int i = 1; i <= n; i++)
                    {
                        combination = HMath.Combinations(n, i);
                        add += combination * points[i] * (-(n - i) * HMath.Pow(d, n - i - 1)) * HMath.Pow(t, i)
                            + combination * points[i] * HMath.Pow(d, n - i) * i * HMath.Pow(t, i - 1);
                    }

                    return add;
            }
        }

        public static float Speed(float t, float duration, params float[] points)
        {
            return FirstDerivative(t / duration, points) / duration;
        }
        #endregion

        #region Vector2
        public static Vector2 Lerp(float t, params Vector2[] points)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            int n = points.Length;
            switch (n)
            {
                case 0: return Vector2.zero;

                case 1: return points[0];

                case 2: return points[0] * d + points[1] * t;

                case 3: return points[0] * d * d + 2F * points[1] * d * t + points[2] * t * t;

                case 4:
                    float td3 = 3F * t * d;
                    return points[0] * d * d * d + points[1] * td3 * d + points[2] * td3 * t + points[3] * t * t * t;

                default:
                    n--;

                    float pt = 1F;

                    Vector2 add = Vector2.zero;

                    for (int i = 0; i <= n; i++, pt *= t)
                        add += HMath.Combinations(n, i) * points[i] * HMath.Pow(d, n - i) * pt;

                    return add;
            }
        }

        public static Vector2 FirstDerivative(float t, params Vector2[] points)
        {
            t = HMath.Clamp01(t);

            if (t == 1F) return Vector2.zero;

            int n = points.Length;
            switch (n)
            {
                case 0:
                case 1:
                    return Vector2.zero;

                case 2: return points[1] - points[0];

                case 3: return 2F * ((points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                case 4:
                    return 3F * ((points[3] - 3F * points[2] + 3F * points[1] - points[0]) * (t * t)
                    + 2F * (points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                default:
                    n--;

                    float combination, d = 1F - t;

                    Vector2 add = points[0] * (-n * HMath.Pow(d, n - 1));

                    for (int i = 1; i <= n; i++)
                    {
                        combination = HMath.Combinations(n, i);
                        add += combination * points[i] * (-(n - i) * HMath.Pow(d, n - i - 1)) * HMath.Pow(t, i)
                            + combination * points[i] * HMath.Pow(d, n - i) * i * HMath.Pow(t, i - 1);
                    }

                    return add;
            }
        }

        public static Vector2 Velocity(float t, float duration, params Vector2[] points)
        {
            return FirstDerivative(t / duration, points) / duration;
        }

        public static Vector2 Tangent(float t, params Vector2[] points)
        {
            return FirstDerivative(t, points).normalized;
        }
        #endregion

        #region Vector3
        public static Vector3 Lerp(float t, params Vector3[] points)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            int n = points.Length;
            switch (n)
            {
                case 0: return Vector3.zero;

                case 1: return points[0];

                case 2: return points[0] * d + points[1] * t;

                case 3: return points[0] * d * d + 2F * points[1] * d * t + points[2] * t * t;

                case 4:
                    float td3 = 3F * t * d;
                    return points[0] * d * d * d + points[1] * td3 * d + points[2] * td3 * t + points[3] * t * t * t;

                default:
                    n--;

                    float pt = 1F;

                    Vector3 add = Vector3.zero;

                    for (int i = 0; i <= n; i++, pt *= t)
                        add += HMath.Combinations(n, i) * points[i] * HMath.Pow(d, n - i) * pt;

                    return add;
            }
        }

        public static Vector3 FirstDerivative(float t, params Vector3[] points)
        {
            t = HMath.Clamp01(t);

            if (t == 1F) return Vector3.zero;

            int n = points.Length;
            switch (n)
            {
                case 0:
                case 1:
                    return Vector3.zero;

                case 2: return points[1] - points[0];

                case 3: return 2F * ((points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                case 4:
                    return 3F * ((points[3] - 3F * points[2] + 3F * points[1] - points[0]) * (t * t)
                    + 2F * (points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                default:
                    n--;

                    float combination, d = 1F - t;

                    Vector3 add = points[0] * (-n * HMath.Pow(d, n - 1));

                    for (int i = 1; i <= n; i++)
                    {
                        combination = HMath.Combinations(n, i);
                        add += combination * points[i] * (-(n - i) * HMath.Pow(d, n - i - 1)) * HMath.Pow(t, i)
                            + combination * points[i] * HMath.Pow(d, n - i) * i * HMath.Pow(t, i - 1);
                    }

                    return add;
            }
        }

        public static Vector3 Velocity(float t, float duration, params Vector3[] points)
        {
            return FirstDerivative(t / duration, points) / duration;
        }

        public static Vector3 Tangent(float t, params Vector3[] points)
        {
            return FirstDerivative(t, points).normalized;
        }
        #endregion

        #region Vector4
        public static Vector4 Lerp(float t, params Vector4[] points)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            int n = points.Length;
            switch (n)
            {
                case 0: return Vector4.zero;

                case 1: return points[0];

                case 2: return points[0] * d + points[1] * t;

                case 3: return points[0] * d * d + 2F * points[1] * d * t + points[2] * t * t;

                case 4:
                    float td3 = 3F * t * d;
                    return points[0] * d * d * d + points[1] * td3 * d + points[2] * td3 * t + points[3] * t * t * t;

                default:
                    n--;

                    float pt = 1F;

                    Vector4 add = Vector4.zero;

                    for (int i = 0; i <= n; i++, pt *= t)
                        add += HMath.Combinations(n, i) * points[i] * HMath.Pow(d, n - i) * pt;

                    return add;
            }
        }

        public static Vector4 FirstDerivative(float t, params Vector4[] points)
        {
            t = HMath.Clamp01(t);

            if (t == 1F) return Vector4.zero;

            int n = points.Length;
            switch (n)
            {
                case 0:
                case 1:
                    return Vector2.zero;

                case 2: return points[1] - points[0];

                case 3: return 2F * ((points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                case 4:
                    return 3F * ((points[3] - 3F * points[2] + 3F * points[1] - points[0]) * (t * t)
                    + 2F * (points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                default:
                    n--;

                    float combination, d = 1F - t;

                    Vector4 add = points[0] * (-n * HMath.Pow(d, n - 1));

                    for (int i = 1; i <= n; i++)
                    {
                        combination = HMath.Combinations(n, i);
                        add += combination * points[i] * (-(n - i) * HMath.Pow(d, n - i - 1)) * HMath.Pow(t, i)
                            + combination * points[i] * HMath.Pow(d, n - i) * i * HMath.Pow(t, i - 1);
                    }

                    return add;
            }
        }

        public static Vector4 Velocity(float t, float duration, params Vector4[] points)
        {
            return FirstDerivative(t / duration, points) / duration;
        }

        public static Vector4 Tangent(float t, params Vector4[] points)
        {
            return FirstDerivative(t, points).normalized;
        }
        #endregion

        #region Color
        public static Color Lerp(float t, params Color[] points)
        {
            t = HMath.Clamp01(t);

            float d = 1F - t;

            int n = points.Length;
            switch (n)
            {
                case 0: return Color.black;

                case 1: return points[0];

                case 2: return points[0] * d + points[1] * t;

                case 3: return points[0] * d * d + 2F * points[1] * d * t + points[2] * t * t;

                case 4:
                    float td3 = 3F * t * d;
                    return points[0] * d * d * d + points[1] * td3 * d + points[2] * td3 * t + points[3] * t * t * t;

                default:
                    n--;

                    float pt = 1F;

                    Color add = Color.black;

                    for (int i = 0; i <= n; i++, pt *= t)
                        add += HMath.Combinations(n, i) * points[i] * HMath.Pow(d, n - i) * pt;

                    return add;
            }
        }

        public static Color FirstDerivative(float t, params Color[] points)
        {
            t = HMath.Clamp01(t);

            if (t == 1F) return Color.black;

            int n = points.Length;
            switch (n)
            {
                case 0:
                case 1:
                    return Color.black;

                case 2: return points[1] - points[0];

                case 3: return 2F * ((points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                case 4:
                    return 3F * ((points[3] - 3F * points[2] + 3F * points[1] - points[0]) * (t * t)
                    + 2F * (points[2] - 2F * points[1] + points[0]) * t + points[1] - points[0]);

                default:
                    n--;

                    float combination, d = 1F - t;

                    Color add = points[0] * (-n * HMath.Pow(d, n - 1));

                    for (int i = 1; i <= n; i++)
                    {
                        combination = HMath.Combinations(n, i);
                        add += combination * points[i] * (-(n - i) * HMath.Pow(d, n - i - 1)) * HMath.Pow(t, i)
                            + combination * points[i] * HMath.Pow(d, n - i) * i * HMath.Pow(t, i - 1);
                    }

                    return add;
            }
        }

        public static Color Velocity(float t, float duration, params Color[] points)
        {
            return FirstDerivative(t / duration, points) / duration;
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