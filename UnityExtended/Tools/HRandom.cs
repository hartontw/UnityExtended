using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// An extended version of UnityEngine.Random
    /// </summary>
    public static class HRandom
    {
        /// <summary>
        /// Returns a random number between 0.0 [inclusive] and 1.0 [inclusive] (Read Only).
        /// </summary>
        public static float Value { get { return Random.value; } }

        /// <summary>
        /// Returns a random point inside a circle with radius 1 (Read Only).
        /// </summary>
        public static Vector2 InsideUnitCircle { get { return Random.insideUnitCircle; } }

        /// <summary>
        /// Returns a random point on the surface of a circle with radius 1 (Read Only).
        /// </summary>
        public static Vector2 OnUnitCircle { get { return InsideUnitCircle.normalized; } }

        /// <summary>
        /// Returns a random point inside a sphere with radius 1 (Read Only).
        /// </summary>
        public static Vector3 InsideUnitSphere { get { return Random.insideUnitSphere; } }

        /// <summary>
        /// Returns a random point on the surface of a sphere with radius 1 (Read Only).
        /// </summary>
        public static Vector3 OnUnitSphere { get { return Random.onUnitSphere; } }

        /// <summary>
        /// Returns a random rotation (Read Only).
        /// </summary>
        public static Quaternion Rotation { get { return Random.rotation; } }

        /// <summary>
        /// Returns a random rotation with uniform distribution (Read Only).
        /// </summary>
        public static Quaternion RotationUniform { get { return Random.rotationUniform; } }

        /// <summary>
        /// Creates a rotation which rotates angle degrees around axis X (Read Only).
        /// </summary>
        public static Quaternion RotationX { get { return RotationAroundAxis(Vector3.right); } }

        /// <summary>
        /// Creates a rotation which rotates angle degrees around axis Y (Read Only).
        /// </summary>
        public static Quaternion RotationY { get { return RotationAroundAxis(Vector3.up); } }

        /// <summary>
        /// Creates a rotation which rotates angle degrees around axis Z (Read Only).
        /// </summary>
        public static Quaternion RotationZ { get { return RotationAroundAxis(Vector3.forward); } }

        /// <summary>
        /// Returns a random RGB color (Read Only).
        /// </summary>
        public static Color RGB { get { return new Color(Value, Value, Value); } }

        /// <summary>
        /// Returns a random RGBA color (Read Only).
        /// </summary>
        public static Color RGBA { get { return new Color(Value, Value, Value, Value); } }

        /// <summary>
        /// Rolls a dice of given faces and returns true if match with chosen face.
        /// </summary>
        /// <param name="faces">
        /// Number of faces of the dice.
        /// </param>
        /// <param name="chosen">
        /// The chosen face.
        /// </param>
        public static bool Dice(int faces, int chosen)
        {
            return Int(faces) == chosen;
        }

        /// <summary>
        /// Roll a dice of given faces and returns true if match with min value.
        /// </summary>
        /// <param name="faces">
        /// Number of faces of the dice.
        /// </param>
        public static bool Dice(int faces)
        {
            return Dice(faces, 0);
        }

        /// <summary>
        /// Returns a random integer number between 0 [inclusive] and length [exclusive].
        /// </summary>
        public static int Index(int length)
        {
            return Random.Range(0, length);
        }

        /// <summary>
        /// Returns a random integer number between 0 [inclusive] and length of given array [exclusive].
        /// </summary>
        public static int Index<T>(T[] array)
        {
            return Index(array.Length);
        }

        /// <summary>
        /// Returns a random integer number between 0 [inclusive] and length of given list [exclusive].
        /// </summary>
        public static int Index<T>(IList<T> list)
        {
            return Index(list.Count);
        }

        /// <summary>
        /// Returns a random element of the given array.
        /// </summary>
        public static T Item<T>(T[] array)
        {
            return array[Index(array)];
        }

        /// <summary>
        /// Returns a random element of the given list.
        /// </summary>
        public static T Item<T>(ICollection<T> list)
        {
            int i = 0;

            T[] values = new T[list.Count];

            foreach (T value in list)
                values[i++] = value;

            return Item(values);
        }

        /// <summary>
        /// Returns a random key of the given dictionary.
        /// </summary>
        public static T Index<T, K>(IDictionary<T, K> dictionary)
        {
            return Item(dictionary.Keys);
        }

        /// <summary>
        /// Returns a random element of the given dictionary.
        /// </summary>
        public static K Item<T, K>(IDictionary<T, K> dictionary)
        {
            return Item(dictionary.Values);
        }

        /// <summary>
        /// Returns a random integer number between min [inclusive] and max [inclusive].
        /// </summary>
        public static int Int(int min, int max)
        {
            return Random.Range(min, max + 1);
        }

        /// <summary>
        /// Returns a random integer number between given range.
        /// </summary>
        public static int Int(Range<int> range)
        {
            return Int(range.Min, range.Max);
        }

        /// <summary>
        /// Returns a random integer number between 0 [inclusive] and max [inclusive].
        /// </summary>
        public static int Int(int max)
        {
            return Int(0, max);
        }

        /// <summary>
        /// Returns a random integer number between -value [inclusive] and value [inclusive].
        /// </summary>
        public static int IntRange(int value = 1)
        {
            return Int(-value, value);
        }

        /// <summary>
        /// Returns a random float number between min [inclusive] and max [inclusive].
        /// </summary>
        public static float Float(float min, float max)
        {
            return Random.Range(min, max);
        }

        /// <summary>
        /// Returns a random float number between given range.
        /// </summary>
        public static float Float(Range<float> range)
        {
            return Float(range.Min, range.Max);
        }

        /// <summary>
        /// Returns a random float number between 0 [inclusive] and max [inclusive].
        /// </summary>
        public static float Float(float max)
        {
            return Float(0F, max);
        }

        /// <summary>
        /// Returns a random float number between -value [inclusive] and value [inclusive].
        /// </summary>>
        public static float FloatRange(float value = 1F)
        {
            return Float(-value, value);
        }

        /// <summary>
        /// Returns a random integer number between min [inclusive] and max [exclusive].
        /// </summary>
        public static int Range(int min, int max)
        {
            return Random.Range(min, max);
        }

        /// <summary>
        /// Returns a random integer number between min and max.
        /// </summary>
        public static int Range(int min, int max, EInclusion mode)
        {
            if (!mode.Minor())
                min++;

            if (!mode.Major())
                max--;

            return Int(min, max);
        }

        /// <summary>
        /// Returns a random integer number between given range.
        /// </summary>
        public static int Range(Range<int> range)
        {
            return Range(range.Min, range.Max);
        }

        /// <summary>
        /// Returns a random float number between min [inclusive] and max [inclusive].
        /// </summary>
        public static float Range(float min, float max)
        {
            return Random.Range(min, max);
        }

        /// <summary>
        /// Returns a random float number between given range.
        /// </summary>
        public static float Range(Range<float> range)
        {
            return Range(range.Min, range.Max);
        }

        /// <summary>
        /// 
        /// </summary>
        public static T Lerp<T>(ILerp<T> value)
        {
            return value.Lerp(Value);
        }

        /// <summary>
        /// Returns a random RGBA color with given alpha.
        /// </summary>
        public static Color RGBa(float alpha = 1F)
        {
            return new Color(Value, Value, Value, alpha);
        }

        /// <summary>
        /// Returns a random point inside a square with given size.
        /// </summary>
        public static Vector2 InsideSquare(Vector2 size)
        {
            return new Vector2(FloatRange(size.x), FloatRange(size.y));
        }

        /// <summary>
        /// Returns a random point inside a cube with given size.
        /// </summary>
        public static Vector3 InsideCube(Vector3 size)
        {
            return new Vector3(FloatRange(size.x), FloatRange(size.y), FloatRange(size.z));
        }

        /// <summary>
        /// Returns a random point inside a circle with given radius.
        /// </summary>
        public static Vector2 InsideCircle(float radius = 1F)
        {
            return InsideUnitCircle * radius;
        }

        /// <summary>
        /// Returns a random point on the surface of a circle with given radius.
        /// </summary>
        public static Vector2 OnCircle(float radius = 1F)
        {
            return OnUnitCircle * radius;
        }

        /// <summary>
        /// Returns a random point inside a sphere with given radius.
        /// </summary>
        public static Vector3 InsideSphere(float radius = 1F)
        {
            return InsideUnitSphere * radius;
        }

        /// <summary>
        /// Returns a random point on the surface of a sphere with given radius.
        /// </summary>
        public static Vector3 OnSphere(float radius = 1F)
        {
            return OnUnitSphere * radius;
        }

        /// <summary>
        /// Returns a random rotation around given axis.
        /// </summary>
        public static Quaternion RotationAroundAxis(Vector3 axis)
        {
            return Quaternion.AngleAxis(Float(360F), axis);
        }
    }
}