using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all bounded numbers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BoundedNumber<T> : BoundedValue<T>, IClamp<T>, IContains<T>
    where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Creates a new bounded value with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        /// <remarks>
        /// The bounded value equals to min.
        /// </remarks>
        public BoundedNumber(T min, T max) : base(min, max) { }

        /// <summary>
        /// Creates a new bounded value with the given arguments.
        /// </summary>
        /// <param name="min">
        /// The smallest value of the range.
        /// </param>
        /// <param name="max">
        /// The largest value of the range.
        /// </param>
        /// <param name="value">
        /// The initial bounded value.
        /// </param>
        public BoundedNumber(T min, T max, T value) : base(min, max)
        {
            Value = value;
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

                _value = Clamp(_value);
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

                _value = Clamp(_value);
            }
        }

        /// <summary>
        /// The bounded value.
        /// </summary>
        public override T Value
        {
            get { return _value; }
            set { _value = Clamp(value); }
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