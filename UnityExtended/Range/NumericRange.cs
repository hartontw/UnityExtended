using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all range of numbers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class NumericRange<T> : Range<T>, IClamp<T>, IContains<T> 
        where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Creates a new numeric range with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        public NumericRange(T min, T max) : base(min, max) { }

        /// <summary>
        /// 
        /// </summary>
        public void Set(params T[] values)
        {
            if (values.Length > 0)
            {
                T min = values[0];
                T max = values[0];

                for(int i = 1; i < values.Length; i++)
                {
                    if (values[i].Less(min))
                        min = values[i];

                    if (values[i].Greater(max))
                        max = values[i];
                }

                this.min = min;
                this.max = max;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Set(IEnumerable<T> values)
        {
            IEnumerator<T> enumerator = values.GetEnumerator();

            if (enumerator.MoveNext())
            {
                T min = enumerator.Current;
                T max = enumerator.Current;

                while(enumerator.MoveNext())
                {
                    if (enumerator.Current.Less(min))
                        min = enumerator.Current;

                    if (enumerator.Current.Greater(max))
                        max = enumerator.Current;
                }

                this.min = min;
                this.max = max;
            }
        }

        /// <summary>
        /// Smallest value of the range.
        /// </summary>
        public override T Min
        {
            get { return min; }

            set
            {
                min = value;
                if (max.Less(min))
                    max = min;
            }
        }

        /// <summary>
        /// Largest value of the range.
        /// </summary>
        public override T Max
        {
            get { return max; }

            set
            {
                max = value;
                if (min.Greater(max))
                    min = max;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public T Clamp(T value)
        {
            return HMath.Clamp<T>(value, Min, Max);
        }

        /// <summary>
        /// 
        /// </summary>
        public T[] Clamp(T[] values)
        {
            return HMath.Clamp(this, values);
        }

        /// <summary>
        /// Returns if a given value is between min (inclusive) and max (inclusive).
        /// </summary>
        /// <param name="value">
        /// The value to check.
        /// </param>
        public virtual bool Contains(T value)
        {
            return min.CompareTo(value) <= 0 && max.CompareTo(value) >= 0;
        }

        /// <summary>
        /// Returns if exists in the given collection some value between range.
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAny(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
                if (Contains(values[i]))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns if a given value collection is between min (inclusive) and max (inclusive).
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAll(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
                if (!Contains(values[i]))
                    return false;

            return true;
        }

        /// <summary>
        /// Returns if exists in the given collection some value between range.
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAny(ICollection<T> values)
        {
            foreach (T value in values)
                if (Contains(value))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns if a given value collection is between min (inclusive) and max (inclusive).
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAll(ICollection<T> values)
        {
            foreach (T value in values)
                if (!Contains(value))
                    return false;

            return true;
        }

        /// <summary>
        /// Returns if exists in the given collection some value between range.
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAny(IEnumerable<T> values)
        {
            foreach (T value in values)
                if (Contains(value))
                    return true;

            return false;
        }

        /// <summary>
        /// Returns if a given value collection is between min (inclusive) and max (inclusive).
        /// </summary>
        /// <param name="value">
        /// The collection to check.
        /// </param>
        public virtual bool ContainsAll(IEnumerable<T> values)
        {
            foreach (T value in values)
                if (!Contains(value))
                    return false;

            return true;
        }
    }
}