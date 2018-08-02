using System;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILerp<T>
    {
        T Lerp(float t);
        T Lerp(float t, Func<float, float> function);
        T Lerp(float t, Easing.Functions function);
    }
}
