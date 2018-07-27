using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContains<T>
    {
        bool Contains(T value);
        bool ContainsAny(params T[] values);
        bool ContainsAll(params T[] values);
        bool ContainsAny(ICollection<T> values);
        bool ContainsAll(ICollection<T> values);
        bool ContainsAny(IEnumerable<T> values);
        bool ContainsAll(IEnumerable<T> values);
    }
}