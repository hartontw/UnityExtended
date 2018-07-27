using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all ranges.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class Range<T> : IRange<T>
    {
        [SerializeField]
        protected T min;
        [SerializeField]
        protected T max;

        /// <summary>
        /// Creates a new range with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        public Range(T min, T max)
        {
            Set(min, max);
        }

        public void Set(T min, T max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Indexer for the range. 0: Min, 1: Max
        /// </summary>
        /// <returns></returns>
        public T this[int index]
        {
            get { return index > 0 ? Max : Min; }

            set
            {
                if (index > 0)
                    Max = value;
                else
                    Min = value;
            }
        }

        /// <summary>
        /// Smallest value of the range.
        /// </summary>
        public virtual T Min
        {
            get { return min; }
            set { min = value; }
        }

        /// <summary>
        /// Largest value of the range.
        /// </summary>
        public virtual T Max
        {
            get { return max; }
            set { max = value; }
        }

        /// <summary>
        /// Returns a nicely formatted string for this range.
        /// </summary>
        public override string ToString()
        {
            return "Min: " + min.ToString() + ", Max: " + max.ToString();
        }

        /// <summary>
        /// Returns true if the given range is exactly equal to this range.
        /// </summary>
        /// <param name="other">
        /// The other range.
        /// </param>
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other == (object)this)
                return true;
            if (!(other is IRange<T>))
                return false;

            IRange<T> range = (IRange<T>)other;
            return range.Min.Equals(Min) && range.Max.Equals(Max);
        }

        /// <summary>
        /// Returns HashCode of the range.
        /// </summary>
        public override int GetHashCode()
        {
            return HUtils.GetHashCode(min, max);
        }

        public static bool operator ==(Range<T> lhs, IRange<T> rhs) { return lhs.Min.Equals(rhs.Min) && lhs.Max.Equals(rhs.Max); }
        public static bool operator ==(IRange<T> lhs, Range<T> rhs) { return lhs.Min.Equals(rhs.Min) && lhs.Max.Equals(rhs.Max); }
        public static bool operator !=(Range<T> lhs, IRange<T> rhs) { return !lhs.Min.Equals(rhs.Min) || !lhs.Max.Equals(rhs.Max); }
        public static bool operator !=(IRange<T> lhs, Range<T> rhs) { return !lhs.Min.Equals(rhs.Min) || !lhs.Max.Equals(rhs.Max); }
    }
}