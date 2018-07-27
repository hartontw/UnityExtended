using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Some utils class
    /// </summary>
    public static class HUtils
    {
        /// <summary>
        /// Returns Hash Code based on prime numbers.
        /// </summary>
        /// <param name="fields">
        /// The fields used to make the Hash Code.
        /// </param>
        public static int GetHashCode(params object[] fields)
        {
            int result = 1;

            for (int i = 0; i < fields.Length; i++)
                result = result * primes[i % primes.Length] + fields[i].GetHashCode();

            return result;
        }
        private static readonly int[] primes = { 31, 37, 41, 43, 47, 53, 59, 61, 67 };

        /// <summary>
        /// 
        /// </summary>
        public static int GetLayerMask(params int[] layers)
        {
            int mask = 1;

            foreach (int layer in layers)
                mask |= layer;

            return mask;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GetLayerMask(params GameObject[] objects)
        {
            int mask = 1;

            foreach (GameObject go in objects)
                mask |= go.layer;

            return mask;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GetLayerMask(params Component[] components)
        {
            int mask = 1;

            foreach (Component component in components)
                mask |= component.gameObject.layer;

            return mask;
        }
    }
}