using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class LerpCoroutine<T> : ManagedCoroutine
    {
        public override IEnumerator Routine
        {
            get
            {
                float t = 0F;
                while(t < 1F)
                {
                    action(lerper.Lerp(t));
                    t = InterpolationValue;

                    yield return new WaitForEndOfFrame();
                }
            }
        }

        public float InterpolationValue { get { return RunningTime / duration; } }

        public readonly float duration;
        public readonly ILerp<T> lerper;
        public readonly Action<T> action;

        public LerpCoroutine(float duration, ILerp<T> lerper, Action<T> action) : base()
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.lerper = lerper;
            this.action = action;
        }

        public LerpCoroutine(MonoBehaviour owner, float duration, ILerp<T> lerper, Action<T> action) : base(owner)
        {
            this.duration = duration > 0F ? duration : Mathf.Epsilon;
            this.lerper = lerper;
            this.action = action;
        }

        public static LerpCoroutine<T> Start(float duration, ILerp<T> lerper, Action<T> action)
        {
            LerpCoroutine<T> coroutine = new LerpCoroutine<T>(duration, lerper, action);
            coroutine.Start();
            return coroutine;
        }
    }
}