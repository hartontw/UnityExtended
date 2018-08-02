using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class LerpCoroutine<T> : UpdateCoroutine<float>
    {
        public override IEnumerator Routine
        {
            get
            {
                float t = 0F;
                while (t < 1F)
                {
                    action(t);
                    yield return base.Routine;
                    t = InterpolationValue;
                }
                action(1F);
            }
        }

        public T InterpolatedValue { get; private set; }
        public float InterpolationValue { get { return RunningTime / duration; } }

        public readonly float duration;

        public LerpCoroutine(float duration, ILerp<T> lerper, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, ILerp<T> lerper, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(float duration, ILerp<T> lerper, Func<float, float> function, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t, function);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, ILerp<T> lerper, Func<float, float> function, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t, function);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(float duration, ILerp<T> lerper, Easing.Functions function, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t, Easing.Get(function));
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, ILerp<T> lerper, Easing.Functions function, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = lerper.Lerp(t, Easing.Get(function));
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(float duration, T start, T end, Func<T, T, float, T> function, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(start, end, t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, T start, T end, Func<T, T, float, T> function, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(start, end, t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(float duration, IRange<T> range, Func<T, T, float, T> function, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(range.Min, range.Max, t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, IRange<T> range, Func<T, T, float, T> function, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(range.Min, range.Max, t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(float duration, Func<float, T> function, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(t);
                action(InterpolatedValue);
            };
        }

        public LerpCoroutine(MonoBehaviour behaviour, float duration, Func<float, T> function, Action<T> action) : base(behaviour)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.action = (t) =>
            {
                InterpolatedValue = function(t);
                action(InterpolatedValue);
            };
        }

        public static implicit operator T(LerpCoroutine<T> coroutine) { return coroutine.InterpolatedValue; }
        public static implicit operator float(LerpCoroutine<T> coroutine) { return coroutine.InterpolationValue; }
    }
}