using System;
using System.Collections;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        public static Coroutinex StartCoroutinex(this MonoBehaviour self, IEnumerator routine)
        {
            Coroutinex coroutine = new Coroutinex(self, routine);
            coroutine.Start();
            return coroutine;
        }

        public static void StopCoroutinex(this MonoBehaviour self, Coroutinex coroutine)
        {
            coroutine.Stop();
        }
    }
}
