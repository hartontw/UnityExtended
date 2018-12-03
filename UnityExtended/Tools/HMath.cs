using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{

    /// <summary>
    /// An extended version of UnityEngine.Mathf
    /// </summary>
    public static class HMath
    {        
        /// <summary>
        /// The infamous 3.14159265358979... value (Read Only).
        /// </summary>
        public const float PI = 3.14159274F;

        /// <summary>
        /// Half of PI value (Read Only).
        /// </summary>
        public const float HalfPI = PI / 2F;

        /// <summary>
        /// Double of PI value (Read Only).
        /// </summary>
        public const float PI2 = PI * 2F;

        /// <summary>
        /// A representation of positive infinity (Read Only).
        /// </summary>
        public const float Infinity = float.PositiveInfinity;

        /// <summary>
        /// A representation of negative infinity (Read Only).
        /// </summary>
        public const float NegativeInfinity = float.NegativeInfinity;

        /// <summary>
        /// Degrees-to-radians conversion constant (Read Only).
        /// </summary>
        public const float Deg2Rad = 0.0174532924F;

        /// <summary>
        /// Radians-to-degrees conversion constant (Read Only).
        /// </summary>
        public const float Rad2Deg = 57.29578F;

        /// <summary>
        /// A tiny floating point value (Read Only).
        /// </summary>
        public static readonly float Epsilon = Mathf.Epsilon;

        /// <summary>
        /// Returns the absolute value of f.
        /// </summary>
        public static float Abs(float f) { return Mathf.Abs(f); }

        /// <summary>
        /// Returns the absolute value of value.
        /// </summary>
        public static int Abs(int value) { return Mathf.Abs(value); }

        /// <summary>
        /// Returns the arc-cosine of f - the angle in radians whose cosine is f.
        /// </summary>
        public static float Acos(float f) { return Mathf.Acos(f); }

        /// <summary>
        /// Compares two floating point values and return true if they are similar.
        /// </summary>
        public static bool Approximately(float a, float b)
        {
            return Mathf.Approximately(a, b);
        }

        /// <summary>
        /// Compares floating point values and returns true if they are similar.
        /// </summary>
        public static bool Approximately(params float[] values)
        {
            if (values.Length > 1)
            {
                for (int i = 1; i < values.Length; i++)
                    if (!Mathf.Approximately(values[i - 1], values[i]))
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Compares floating point values and returns true if they are similar.
        /// </summary>
        public static bool Approximately(ICollection<float> values)
        {
            float last = 0F;

            using (IEnumerator<float> enumer = values.GetEnumerator())
            {
                if (enumer.MoveNext())
                {
                    last = enumer.Current;

                    while (enumer.MoveNext())
                    {
                        float current = enumer.Current;

                        if (!Mathf.Approximately(last, current))
                            return false;

                        last = current;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Returns the arc-sine of f - the angle in radians whose sine is f.
        /// </summary>
        public static float Asin(float f) { return Mathf.Asin(f); }

        /// <summary>
        /// Returns the arc-tangent of f - the angle in radians whose tangent is f.
        /// </summary>
        public static float Atan(float f) { return Mathf.Atan(f); }

        /// <summary>
        /// Returns the angle in radians whose Tan is y/x.
        /// </summary>
        public static float Atan2(float y, float x) { return Mathf.Atan2(y, x); }

        /// <summary>
        /// Returns the average of a group of values.
        /// </summary>
        public static float Average(params float[] values)
        {
            float total = 0F;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total / values.Length;
        }

        /// <summary>
        /// Returns the average of a group of values.
        /// </summary>
        public static Vector2 Average(params Vector2[] values)
        {
            Vector2 total = Vector2.zero;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total / values.Length;
        }

        /// <summary>
        /// Returns the average of a group of values.
        /// </summary>
        public static Vector3 Average(params Vector3[] values)
        {
            Vector3 total = Vector3.zero;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total / values.Length;
        }

        /// <summary>
        /// Returns the average of a group of values.
        /// </summary>
        public static Vector4 Average(params Vector4[] values)
        {
            Vector4 total = Vector4.zero;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total / values.Length;
        }

        /// <summary>
        /// Returns the average of a group of values.
        /// </summary>
        public static Color Average(params Color[] values)
        {
            Color total = Color.black;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total / values.Length;
        }

        /// <summary>
        /// Returns if a value is between min [inclusive] and max [inclusive].
        /// </summary>
        public static bool Between(float min, float max, float value)
        {
            return !(value < min || value > max);
        }

        /// <summary>
        /// Returns if a value is between min [inclusive] and max [exclusive].
        /// </summary>
        public static bool Between(int min, int max, int value)
        {
            return !(value < min || value >= max);
        }

        /// <summary>
        /// Returns if a value is between min and max.
        /// </summary>
        public static bool Between<T>(T min, T max, T value, EInclusion mode = EInclusion.Inclusive) 
            where T : IComparable, IComparable<T>
        {
            return mode.Minor(min, value) && mode.Major(max, value);
        }

        /// <summary>
        /// Returns if a value is between a range.
        /// </summary>
        public static bool Between<T>(IRange<T> range, T value, EInclusion mode = EInclusion.Inclusive)
            where T : IComparable, IComparable<T>
        {
            return mode.Minor(range.Min, value) && mode.Major(range.Max, value);
        }

        /// <summary>
        /// Returns the smallest integer greater to or equal to f.
        /// </summary>
        public static float Ceil(float f) { return Mathf.Ceil(f); }

        /// <summary>
        /// Returns the smallest integer greater to or equal to f.
        /// </summary>
        public static int CeilToInt(float f) { return Mathf.CeilToInt(f); }

        /// <summary>
        /// Clamps value between min and max and returns value.
        /// </summary>
        public static int Clamp(int value, int min, int max) { return Mathf.Clamp(value, min, max); }

        /// <summary>
        /// Clamps a value between a minimum float and maximum float value.
        /// </summary>
        public static float Clamp(float value, float min, float max) { return Mathf.Clamp(value, min, max); }

        /// <summary>
        /// Clamps a value between a minimum float and maximum float value.
        /// </summary>
        public static T Clamp<T>(T value, T min, T max) where T : IComparable, IComparable<T>
        {
            if (value.CompareTo(max) > 0)
                return max;

            if (value.CompareTo(min) < 0)
                return min;

            return value;
        }

        /// <summary>
        /// Clamps values between min and max.
        /// </summary>
        public static T[] Clamp<T>(T min, T max, params T[] values) where T : IComparable, IComparable<T>
        {
            T[] clamped = new T[values.Length];

            for (int i = 0; i < values.Length; i++)
                clamped[i] = Clamp<T>(values[i], min, max);

            return clamped;
        }

        /// <summary>
        /// Clamps values between a range.
        /// </summary>
        public static T[] Clamp<T>(IRange<T> range, params T[] values) where T : IComparable, IComparable<T>
        {
            T[] clamped = new T[values.Length];

            for (int i = 0; i < values.Length; i++)
                clamped[i] = Clamp<T>(values[i], range.Min, range.Max);

            return clamped;
        }

        /// <summary>
        /// Clamps collection between min and max.
        /// </summary>
        public static K Clamp<T, K>(K collection, T min, T max)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K clamped = new K();

            foreach (T value in collection)
                clamped.Add(Clamp<T>(value, min, max));

            return clamped;
        }

        /// <summary>
        /// Clamps a value between a range.
        /// </summary>
        public static T Clamp<T>(T value, IRange<T> range) where T : IComparable, IComparable<T>
        {
            return Clamp<T>(value, range.Min, range.Max);
        }

        /// <summary>
        /// Clamps collection between a range.
        /// </summary>
        public static K Clamp<T, K>(K collection, IRange<T> range)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K clamped = new K();

            foreach (T value in collection)
                clamped.Add(Clamp<T>(value, range.Min, range.Max));

            return clamped;
        }

        /// <summary>
        /// Clamps value between 0 and 1 and returns value.
        /// </summary>
        public static float Clamp01(float value) { return Mathf.Clamp01(value); }

        /// <summary>
        /// Returns the closest power of two value.
        /// </summary>
        public static int ClosestPowerOfTwo(int value) { return Mathf.ClosestPowerOfTwo(value); }

        /// <summary>
        /// Find the number of possible combinations that can be obtained by taking a sample of items from a set of objects.
        /// </summary>
        public static int Combinations(int objects, int sample)
        {
            if (sample > objects) return 0;
            if (sample == objects) return 1;

            if (sample > objects - sample)
                sample = objects - sample;

            int combinations = 1;

            for (int i = 1; i <= sample; i++, objects--)
                combinations = (combinations * objects) / i;

            return combinations;
        }

        /// <summary>
        /// Convert a color temperature in Kelvin to RGB color.
        /// </summary>
        /// <param name="kelvin">
        /// Temperature in Kelvin. Range 1000 to 40000 Kelvin
        /// </param>
        /// <returns>
        /// Correlated Color Temperature as floating point RGB color.
        /// </returns>
        public static Color CorrelatedColorTemperatureToRGB(float kelvin) { return Mathf.CorrelatedColorTemperatureToRGB(kelvin); }

        /// <summary>
        /// Returns the cosine of angle f in radians.
        /// </summary>
        public static float Cos(float f) { return Mathf.Cos(f); }

        /// <summary>
        /// Calculates the shortest difference between two given angles given in degrees.
        /// </summary>
        public static float DeltaAngle(float current, float target) { return Mathf.DeltaAngle(current, target); }

        /// <summary>
        /// Returns true if the sign of given numbers are distinct.
        /// </summary>
        public static bool DistinctSign(float a, float b)
        {
            return !SameSign(a, b);
        }

        /// <summary>
        /// Returns true if the sign of given numbers are distinct.
        /// </summary>
        public static bool DistinctSign(params float[] values)
        {
            return !SameSign(values);
        }

        /// <summary>
        /// Returns e raised to the specified power.
        /// </summary>
        public static float Exp(float power) { return Mathf.Exp(power); }

        /// <summary>
        /// 
        /// </summary>
        public static ushort FloatToHalf(float val) { return Mathf.FloatToHalf(val); }

        /// <summary>
        /// Returns the largest integer smaller to or equal to f.
        /// </summary>
        public static float Floor(float f) { return Mathf.Floor(f); }

        /// <summary>
        /// Returns the largest integer smaller to or equal to f.
        /// </summary>
        public static int FloorToInt(float f) { return Mathf.FloorToInt(f); }

        /// <summary>
        /// 
        /// </summary>
        public static float Gamma(float value, float absmax, float gamma) { return Mathf.Gamma(value, absmax, gamma); }

        /// <summary>
        /// Converts the given value from gamma (sRGB) to linear color space.
        /// </summary>
        public static float GammaToLinearSpace(float value) { return Mathf.GammaToLinearSpace(value); }

        /// <summary>
        /// 
        /// </summary>
        public static float HalfToFloat(ushort val) { return Mathf.HalfToFloat(val); }

        /// <summary>
        /// Returns values between min [inclusive] and max [inclusive].
        /// </summary>
        public static K Inside<T, K>(T min, T max, params T[] values)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (Between(min, max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Returns values between min [inclusive] and max [inclusive].
        /// </summary>
        public static K Inside<T, K>(IRange<T> range, params T[] values)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (Between(range.Min, range.Max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Returns values between min and max.
        /// </summary>
        public static K Inside<T, K>(IRange<T> range, ICollection<T> values, EInclusion mode = EInclusion.Inclusive)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (Between(range.Min, range.Max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Returns values between min [inclusive] and max [inclusive].
        /// </summary>
        public static K Outside<T, K>(T min, T max, params T[] values)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (!Between(min, max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Returns values between min [inclusive] and max [inclusive].
        /// </summary>
        public static K Outside<T, K>(IRange<T> range, params T[] values)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (!Between(range.Min, range.Max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Returns values between min and max.
        /// </summary>
        public static K Outside<T, K>(IRange<T> range, ICollection<T> values, EInclusion mode = EInclusion.Inclusive)
            where T : IComparable, IComparable<T>
            where K : ICollection<T>, new()
        {
            K inside = new K();

            foreach (T value in values)
            {
                if (!Between(range.Min, range.Max, value))
                    inside.Add(value);
            }

            return inside;
        }

        /// <summary>
        /// Calculates the linear parameter t that produces the interpolant value within the range [a, b].
        /// </summary>
        public static float InverseLerp(float a, float b, float value) { return Mathf.InverseLerp(a, b, value); }

        /// <summary>
        /// Returns true if the value is power of two.
        /// </summary>
        public static bool IsPowerOfTwo(int value) { return Mathf.IsPowerOfTwo(value); }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="a">
        /// The start value.
        /// </param>
        /// <param name="b">
        /// The end value.
        /// </param>
        /// <param name="t">
        /// The interpolation value between the two floats.
        /// </param>
        /// <returns>
        /// The interpolated float result between the two float values.
        /// </returns>
        public static float Lerp(float a, float b, float t) { return Mathf.Lerp(a, b, t); }

        /// <summary>
        /// Linearly interpolates a range by t.
        /// </summary>
        public static float Lerp(IRange<float> range, float t) { return Lerp(range.Min, range.Max, t); }

        /// <summary>
        /// Linearly interpolates between values by t.
        /// </summary>
        public static float Lerp(float[] values, float t)
        {
            return LerpUnclamped(values, Clamp01(t));
        }

        /// <summary>
        /// Linearly interpolates between values by t.
        /// </summary>
        public static float Lerp(ICollection<float> values, float t)
        {
            int i = 0;
            float[] v = new float[values.Count];

            foreach (float value in values)
                v[i++] = value;

            return Lerp(v, t);
        }

        /// <summary>
        /// Linearly interpolates a range by t.
        /// </summary>
        public static T Lerp<T>(ILerp<T> range, float t)
        {
            return range.Lerp(t);
        }

        /// <summary>
        /// Same as Lerp but makes sure the values interpolate correctly when they wrap around 360 degrees.
        /// </summary>
        public static float LerpAngle(float a, float b, float t) { return Mathf.LerpAngle(a, b, t); }

        /// <summary>
        /// Linearly interpolates between a and b by t with no limit to t.
        /// </summary>
        /// <param name="a">
        /// The start value.
        /// </param>
        /// <param name="b">
        /// The end value.
        /// </param>
        /// <param name="t">
        /// The interpolation between the two floats.
        /// </param>
        /// <returns>
        /// The float value as a result from the linear interpolation.
        /// </returns>
        public static float LerpUnclamped(float a, float b, float t) { return Mathf.LerpUnclamped(a, b, t); }

        /// <summary>
        /// Linearly interpolates a range by t with no limit to t.
        /// </summary>
        public static float LerpUnclamped(IRange<float> range, float t) { return LerpUnclamped(range.Min, range.Max, t); }

        /// <summary>
        /// Linearly interpolates between values by t.
        /// </summary>
        public static float LerpUnclamped(float[] values, float t)
        {
            if (values.Length == 0)
                throw new Exception("The values array is empty");

            if (values.Length == 1)
                return values[0];

            if (t <= 0F)
                return values[0] + (values[1] - values[0]) * t;

            int last = values.Length - 1;

            if (t >= 1F)
                return values[last] + (values[last] - values[last - 1]) * (t - 1F);

            t = t * last;

            int index = FloorToInt(t);

            t = t - index;

            return Lerp(values[index], values[index + 1], t);
        }

        /// <summary>
        /// Linearly interpolates between values by t.
        /// </summary>
        public static float LerpUnclamped(ICollection<float> values, float t)
        {
            float[] array = new float[values.Count];
            values.CopyTo(array, 0);

            return LerpUnclamped(array, t);
        }

        /// <summary>
        /// Converts the given value from linear to gamma (sRGB) color space.
        /// </summary>
        public static float LinearToGammaSpace(float value) { return Mathf.LinearToGammaSpace(value); }

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        public static float Log(float f, float p) { return Mathf.Log(f, p); }

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        public static float Log(float f) { return Mathf.Log(f); }

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        public static float Log10(float f) { return Mathf.Log10(f); }

        /// <summary>
        /// Returns largest of two values.
        /// </summary>
        public static float Max(float a, float b) { return Mathf.Max(a, b); }

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        public static float Max(params float[] values) { return Mathf.Max(values); }

        /// <summary>
        /// Returns the largest of two or more values.
        /// </summary>
        public static int Max(int a, int b) { return Mathf.Max(a, b); }

        /// <summary>
        /// Returns the largest of two or more values.
        /// </summary>
        public static int Max(params int[] values) { return Mathf.Max(values); }

        /// <summary>
        /// Returns the largest of two values.
        /// </summary>
        public static T Max<T>(T a, T b) where T : IComparable, IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;

            return b;
        }

        /// <summary>
        /// Returns the largest of two or more values.
        /// </summary>
        public static T Max<T>(params T[] values) where T : IComparable, IComparable<T>
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                    max = values[i];
            }
            return max;
        }

        /// <summary>
        /// Returns the smallest of two values.
        /// </summary>
        public static float Min(float a, float b) { return Mathf.Min(a, b); }

        /// <summary>
        /// Returns the smallest of two or more values.
        /// </summary>
        public static float Min(params float[] values) { return Mathf.Min(values); }

        /// <summary>
        /// Returns the smallest of two values.
        /// </summary>
        public static int Min(int a, int b) { return Mathf.Min(a, b); }

        /// <summary>
        /// Returns the smallest of two or more values.
        /// </summary>
        public static int Min(params int[] values) { return Mathf.Min(values); }

        /// <summary>
        /// Returns the smallest of two values.
        /// </summary>
        public static T Min<T>(T a, T b) where T : IComparable, IComparable<T>
        {
            if (a.CompareTo(b) < 0)
                return a;

            return b;
        }

        /// <summary>
        /// Returns the smallest of two or more values.
        /// </summary>
        public static T Min<T>(params T[] values) where T : IComparable, IComparable<T>
        {
            T min = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(min) < 0)
                    min = values[i];
            }

            return min;
        }

        /// <summary>
        /// Moves a value current towards target.
        /// </summary>
        /// <param name="current">
        /// The current value.
        /// </param>
        /// <param name="target">
        /// The value to move towards.
        /// </param>
        /// <param name="maxDelta">
        /// The maximum change that should be applied to the value.
        /// </param>
        public static float MoveTowards(float current, float target, float maxDelta) { return Mathf.MoveTowards(current, target, maxDelta); }

        /// <summary>
        /// Same as MoveTowards but makes sure the values interpolate correctly when they wrap around 360 degrees.
        /// </summary>
        public static float MoveTowardsAngle(float current, float target, float maxDelta) { return Mathf.MoveTowardsAngle(current, target, maxDelta); }

        /// <summary>
        /// Returns the next power of two value.
        /// </summary>
        public static int NextPowerOfTwo(int value) { return Mathf.NextPowerOfTwo(value); }

        /// <summary>
        /// Returns true if the sign of given numbers are opposite.
        /// </summary>
        public static bool OppositeSign(float a, float b)
        {
            return a < 0F && b > 0F || a > 0F && b < 0F;
            //return Sign(a) != 0F && Sign(b) != 0 && Distinct(a, b);
        }

        /// <summary>
        /// Generate 2D Perlin noise.
        /// </summary>
        /// <param name="x">
        /// X-coordinate of sample point.
        /// </param>
        /// <param name="y">
        /// Y-coordinate of sample point.
        /// </param>
        /// <returns>
        /// Value between 0.0 and 1.0.
        /// </returns>
        public static float PerlinNoise(float x, float y) { return Mathf.PerlinNoise(x, y); }

        /// <summary>
        /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
        /// </summary>
        public static float PingPong(float t, float length) { return Mathf.PingPong(t, length); }

        /// <summary>
        /// Returns f raised to power p.
        /// </summary>
        public static float Pow(float f, float p) { return Mathf.Pow(f, p); }

        /// <summary>
        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        /// </summary>
        public static float Repeat(float t, float length) { return Mathf.Repeat(t, length); }

        /// <summary>
        /// Returns f rounded to the nearest integer.
        /// </summary>
        public static float Round(float f) { return Mathf.Round(f); }

        /// <summary>
        /// Returns f rounded to the nearest integer.
        /// </summary>
        public static int RoundToInt(float f) { return Mathf.RoundToInt(f); }

        /// <summary>
        /// Returns true if the sign of given numbers are the same.
        /// </summary>
        public static bool SameSign(float a, float b)
        {
            return Sign(a) == Sign(b);
        }

        /// <summary>
        /// Returns true if the sign of given numbers are the same.
        /// </summary>
        public static bool SameSign(params float[] values)
        {
            if (values.Length > 0)
            {
                float sign = Sign(values[0]);

                for (int i = 1; i < values.Length; i++)
                    if (Sign(values[i]) != sign)
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Returns the sign of f. 
        /// </summary>
        /// <returns>
        /// -1f, 0f, 1f
        /// </returns>
        public static float Sign(float f, bool zero = false)
        {
            return !zero || f != 0F ? Mathf.Sign(f) : 0F;
        }

        /// <summary>
        /// Returns the sign of given number converted to integer.
        /// </summary>
        public static int SignToInt(float value, bool zero = false)
        {
            return (int)Sign(value, zero);
        }

        /// <summary>
        /// Returns the sine of angle f in radians.
        /// </summary>
        /// <param name="f">
        /// The argument as a radian.
        /// </param>
        /// <returns>
        /// The return value between -1 and +1.
        /// </returns>
        public static float Sin(float f) { return Mathf.Sin(f); }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
        {
            return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
        {
            return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
        {
            return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        /// <summary>
        /// Interpolates between min and max with smoothing at the limits.
        /// </summary>
        public static float SmoothStep(float from, float to, float t) { return Mathf.SmoothStep(from, to, to); }

        /// <summary>
        /// Returns square root of f.
        /// </summary>
        public static float Sqrt(float f) { return Mathf.Sqrt(f); }

        /// <summary>
        /// Returns the tangent of angle f in radians.
        /// </summary>
        public static float Tan(float f) { return Mathf.Tan(f); }
    }
}