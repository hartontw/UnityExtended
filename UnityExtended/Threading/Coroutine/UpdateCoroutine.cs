using System;
using System.Collections;
using UnityEngine;

namespace UnityExtended
{
    public abstract class UpdateCoroutine<T> : ManagedCoroutine
    {
        public override IEnumerator Routine
        {
            get
            {
                if (fixedUpdate)
                    yield return new WaitForFixedUpdate();
                else
                    yield return new WaitForEndOfFrame();
            }
        }

        protected Action<T> action;

        public bool fixedUpdate = false;

        public UpdateCoroutine() : base() { }
        public UpdateCoroutine(MonoBehaviour behaviour) : base(behaviour) { }
    }
}
