using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class DelayCoroutine : ManagedCoroutine
    {
        public override IEnumerator Routine
        {
            get
            {
                yield return new WaitForSeconds(delay);

                try
                {
                    action.Invoke();
                }
                catch(Exception ex)
                {
                    Info = ex.Message;
                    Debug.LogWarning(Info);
                    State = EProcess.Failed;
                }
            }
        }

        public readonly Action action;
        public readonly float delay;

        public float Diversion { get { return RunningTime / delay; } }

        public DelayCoroutine(float delay, Action action) : base()
        {
            this.action = action;
            this.delay = delay > 0F ? delay : Mathf.Epsilon;
        }

        public DelayCoroutine(MonoBehaviour owner, float delay, Action action) : base(owner)
        {
            this.action = action;
            this.delay = delay > 0F ? delay : Mathf.Epsilon;
        }

        public static DelayCoroutine Start(float delay, Action action)
        {
            DelayCoroutine coroutine = new DelayCoroutine(delay, action);
            coroutine.Start();
            return coroutine;
        }
    }
}