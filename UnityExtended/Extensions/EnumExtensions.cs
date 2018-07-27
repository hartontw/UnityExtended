using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExtended
{
    public static partial class Extensions
    {
        #region EInclusion

        /// <summary>
        /// 
        /// </summary>
        public static bool Minor(this EInclusion inclusion)
        {
            //return inclusion == EInclusion.Inclusive || inclusion == EInclusion.Inclusive_Exclusive;
            return ((int)inclusion | 1) == 3;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Major(this EInclusion inclusion)
        {
            //return inclusion == EInclusion.Inclusive || inclusion == EInclusion.Exclusive_Inclusive;
            return ((int)inclusion | 2) == 3;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Minor<T>(this EInclusion inclusion, T min, T value) where T : IComparable, IComparable<T>
        {
            int comparison = min.CompareTo(value);

            if (comparison > 0)
                return false;

            if (comparison < 0)
                return true;

            return inclusion.Minor();
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Major<T>(this EInclusion inclusion, T max, T value) where T : IComparable, IComparable<T>
        {
            int comparison = max.CompareTo(value);

            if (comparison < 0)
                return false;

            if (comparison > 0)
                return true;

            return inclusion.Major();
        }
        #endregion
    }
}
