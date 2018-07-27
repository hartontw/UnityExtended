using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        /// Returns if a value is between min and max.
        /// </summary>
        public static bool Between(this int self, int min, int max)
        {
            return self >= min && self < max;
        }

        /// <summary>
        /// Returns if a value is between given range.
        /// </summary>
        public static bool Between(this int self, IRange<int> range)
        {
            return self.Between(range.Min, range.Max);
        }

        /// <summary>
        /// Clamps value between min and max and returns value.
        /// </summary>
        public static int Clamp(this int self, int min, int max)
        {
            return Mathf.Clamp(self, min, max);
        }

        /// <summary>
        /// Clamps value between given range.
        /// </summary>
        public static int Clamp(this int self, IRange<int> range)
        {
            return Mathf.Clamp(self, range.Min, range.Max);
        }

        /// <summary>
        /// Return the sign of an integer.
        /// </summary>
        public static int Sign(this int self)
        {
            return self < 0 ? -1 : 1;
        }

        /// <summary>
        /// Returns if the integer is pair
        /// </summary>
        public static bool Pair(this int self)
        {
            return self % 2 == 0;
        }
    }
}