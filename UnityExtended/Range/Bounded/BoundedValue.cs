using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Base class for all bounded values.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public abstract class BoundedValue<T> : Range<T>
    {
        [SerializeField]
        protected T _value;

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
        public BoundedValue(T min, T max) : base(min, max)
        {
            Value = min;
        }

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
        public BoundedValue(T min, T max, T value) : base(min, max)
        {
            Value = value;
        }

        /// <summary>
        /// The bounded value.
        /// </summary>
        public virtual T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Returns a nicely formatted string for this range.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + ", Value: " + Value.ToString();
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
            if (!(other is BoundedValue<T>))
                return false;

            BoundedValue<T> bounded = (BoundedValue<T>)other;
            return bounded._value.Equals(_value) && bounded.min.Equals(min) && bounded.max.Equals(max);
        }

        /// <summary>
        /// Returns HashCode of the range.
        /// </summary>
        public override int GetHashCode()
        {
            return HUtils.GetHashCode(_value, min, max);
        }

        public static implicit operator T(BoundedValue<T> bounded) { return bounded.Value; }
        public static bool operator ==(BoundedValue<T> lhs, BoundedValue<T> rhs) { return lhs.Value.Equals(rhs.Value) && lhs.min.Equals(rhs.min) && lhs.max.Equals(rhs.max); }
        public static bool operator ==(BoundedValue<T> lhs, T rhs) { return lhs.Value.Equals(rhs); }
        public static bool operator ==(T lhs, BoundedValue<T> rhs) { return lhs.Equals(rhs.Value); }
        public static bool operator !=(BoundedValue<T> lhs, BoundedValue<T> rhs) { return !lhs.Value.Equals(rhs.Value) || !lhs.min.Equals(rhs.min) || !lhs.max.Equals(rhs.max); }
        public static bool operator !=(BoundedValue<T> lhs, T rhs) { return !lhs.Value.Equals(rhs); }
        public static bool operator !=(T lhs, BoundedValue<T> rhs) { return !lhs.Equals(rhs.Value); }
    }
}
