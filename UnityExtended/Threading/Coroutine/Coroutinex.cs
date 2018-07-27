using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class Coroutinex : ManagedCoroutine
    {
        private readonly IEnumerator routine;
        public override IEnumerator Routine { get { return routine; } }

        public Coroutinex(IEnumerator routine) : base()
        {
            this.routine = routine;
        }

        public Coroutinex(MonoBehaviour behaviour, IEnumerator routine) : base(behaviour)
        {
            this.routine = routine;
        }

        public static Coroutinex Start(IEnumerator routine)
        {
            Coroutinex coroutine = new Coroutinex(routine);
            return coroutine;
        }
    }
}
