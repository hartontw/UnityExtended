
namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IClamp<T>
    {
        T Clamp(T value);
        T[] Clamp(T[] values);
    }
}
