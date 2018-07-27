
namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRange<T>
    {
        T Min { get; set; }
        T Max { get; set; }
    }
}