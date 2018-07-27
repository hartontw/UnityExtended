using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        #region IComparable
        public static bool Less<T>(this T value, T other) where T : IComparable, IComparable<T>
        {
            return value.CompareTo(other) < 0;
        }

        public static bool LessEqual<T>(this T value, T other) where T : IComparable, IComparable<T>
        {
            return value.CompareTo(other) <= 0;
        }

        public static bool Greater<T>(this T value, T other) where T : IComparable, IComparable<T>
        {
            return value.CompareTo(other) > 0;
        }

        public static bool GreaterEqual<T>(this T value, T other) where T : IComparable, IComparable<T>
        {
            return value.CompareTo(other) >= 0;
        }
        #endregion

        #region IEnumerator
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string GetName(this IEnumerator self)
        {
            string raw = self.ToString();
            int s = raw.IndexOf('<') + 1;
            int e = raw.IndexOf('>');
            return raw.Substring(s, e - s);
        }
        #endregion

        #region IEnumerable
        /// <summary>
        /// Copy the the elements of the enumerable to a new array.
        /// </summary>
        public static T[] ToArray<T>(this IEnumerable<T> self)
        {
            return new HashSet<T>(self).ToArray();
        }

        /// <summary>
        /// Returns random element from the enumerable.
        /// </summary>
        public static T Random<T>(this IEnumerable<T> self)
        {
            return self.ToArray().Random();
        }
        #endregion

        #region ICollection
        /// <summary>
        /// Copy the the elements of the collection to a new array.
        /// </summary>
        public static T[] ToArray<T>(this ICollection<T> self)
        {
            T[] values = new T[self.Count];

            self.CopyTo(values, 0);

            return values;
        }
        #endregion

        #region IList
        /// <summary>
        /// 
        /// </summary>
        public static void AddIf<T>(this IList<T> self, T value)
        {
            if (!self.Contains(value))
                self.Add(value);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RemoveIf<T>(this IList<T> self, T value)
        {
            if (self.Contains(value))
                self.Remove(value);
        }

        /// <summary>
        /// Returns first element of the list.
        /// </summary>
        public static T First<T>(this IList<T> self)
        {
            return self[0];
        }

        /// <summary>
        /// Returns the last accessible index of the list.
        /// </summary>
        public static int Bound<T>(this IList<T> self)
        {
            return self.Count - 1;
        }

        /// <summary>
        /// Returns last element of the list.
        /// </summary>
        public static T Last<T>(this IList<T> self)
        {
            return self[self.Bound()];
        }

        /// <summary>
        /// Returns random element from the list.
        /// </summary>
        public static T Random<T>(this IList<T> self)
        {
            return self[HRandom.Index(self)];
        }
        #endregion
    }
}
