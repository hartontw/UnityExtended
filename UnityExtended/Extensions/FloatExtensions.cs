using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        ///Returns if a value is between min and max.
        /// </summary>
        public static bool Between(this float self, float min, float max)
        {
            return self >= min && self <= max;
        }

        /// <summary>
        /// Returns if a value is between min and max.
        /// </summary>
        public static bool Between(this float self, IRange<float> range)
        {
            return self.Between(range.Min, range.Max);
        }

        /// <summary>
        /// Compares the floating point value with an other and returns true if they are similar.
        /// </summary>
        public static bool Approximately(this float self, float other)
        {
            return Mathf.Approximately(self, other);
        }

        /// <summary>
        /// Compares the floating point value with an other and returns true if they are similar.
        /// </summary>
        public static bool Approximately(this float self, float other, float precision)
        {
            return self.Between(other - precision, other + precision);
        }

        /// <summary>
        /// Clamps value between 0 and 1 and returns value.
        /// </summary>
        public static float Clamp01(this float self)
        {
            return Mathf.Clamp01(self);
        }

        /// <summary>
        /// Clamps value between a minimum float and maximum float value.
        /// </summary>
        public static float Clamp(this float self, float min, float max)
        {
            return Mathf.Clamp(self, min, max);
        }

        /// <summary>
        /// Clamps value between given range.
        /// </summary>
        public static float Clamp(this float self, IRange<float> range)
        {
            return Mathf.Clamp(self, range.Min, range.Max);
        }

        /// <summary>
        /// Returns a random float number between self [inclusive] and other [inclusive].
        /// </summary>
        public static float Random(this float self, float other)
        {
            return UnityEngine.Random.Range(self, other);
        }
    }
}