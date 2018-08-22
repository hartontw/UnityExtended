using System;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Interpolation
    {
        public static Func<float, float> PingPong(float loops)
        {
            return (t) => { return HMath.PingPong(t * loops * 2F, 1F); };
        }

        public static Func<float, float> Curve(AnimationCurve curve)
        {
            return (t) => { return curve != null ? curve.Evaluate(t) : t; };
        }

        public static Func<float, float> Plot(string formula)
        {
            formula = formula.Replace(" ", "");
            

            return (t) =>
            {
                return 0F;
            };
        }

        public static Func<float, float> Ease(Easing.Functions function)
        {
            return Easing.Get(function);
        }

        public static Func<float, Vector2> GetVector2(Func<float, float> function, float duration, Vector2 start, Vector2 end)
        {
            Vector2 direction = end - start;

            return (t) =>
            {
                t = Mathf.Clamp01(t / duration);
                return new Vector2(direction.x * t, direction.y * function(t));
            };
        }

        public static Func<float, Vector2> GetVector2(Easing.Functions function, float duration, Vector2 start, Vector2 end)
        {
            return GetVector2(Easing.Get(function), duration, start, end);
        }

        public static Func<float, Vector3> GetVector3(Func<float, float> function, float duration, Vector3 start, Vector3 end, float angle = 0F)
        {
            Vector3 direction = end - start;

            float magnitude = direction.magnitude;
            Vector3 normalized = direction.normalized;

            Vector3 axis = normalized != Vector3.up && normalized != Vector3.down ? Vector3.up : Vector3.right;

            Vector3 cross = Quaternion.AngleAxis(angle, normalized) * Vector3.Cross(axis, normalized);

            float component = 1F / Mathf.Sqrt(2F);

            Vector3 right = Quaternion.AngleAxis(45F, cross) * normalized * component;
            Vector3 up = Quaternion.AngleAxis(-45F, cross) * normalized * component;

            return (t) =>
            {
                t = Mathf.Clamp01(t / duration);
                return start + (right * t + up * function(t)) * magnitude;
            };
        }

        public static Func<float, Vector3> GetVector3(Easing.Functions function, float duration, Vector3 start, Vector3 end, float angle = 0F)
        {
            return GetVector3(Easing.Get(function), duration, start, end, angle);
        }

        public static Func<float, bool> Translate(Func<float, float> function, float duration, Transform transform, float distance)
        {
            float angle = -Vector3.SignedAngle(transform.up, Vector3.up, transform.forward);
            Func<float, Vector3> f = GetVector3(function, duration, transform.position, transform.position + transform.forward * distance, angle);
            Vector3 last = transform.position;

            return (t) =>
            {
                transform.position = f(t);
                transform.rotation = Quaternion.LookRotation(transform.position - last);
                last = transform.position;

                return t / duration >= 1F;
            };
        }

        public static Func<float, bool> Translate(Easing.Functions function, float duration, Transform transform, float distance)
        {
            return Translate(Easing.Get(function), duration, transform, distance);
        }
    }
}