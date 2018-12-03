using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    public static class Geometry
    {
        public static Bounds GetBounds(params Bounds[] bounds)
        {
            float mx = bounds[0].min.x;
            float my = bounds[0].min.y;
            float mz = bounds[0].min.z;
            float Mx = bounds[0].max.x;
            float My = bounds[0].max.y;
            float Mz = bounds[0].max.z;

            for (int i = 1; i < bounds.Length; i++)
            {
                mx = HMath.Min(mx, bounds[i].min.x);
                my = HMath.Min(my, bounds[i].min.y);
                mz = HMath.Min(mz, bounds[i].min.z);
                Mx = HMath.Max(Mx, bounds[i].max.x);
                My = HMath.Max(My, bounds[i].max.y);
                Mz = HMath.Max(Mz, bounds[i].max.z);
            }

            Vector3 size = new Vector3(Mx - mx, My - my, Mz - mz);
            Vector3 center = new Vector3(mx, my, mz) + size / 2F;

            return new Bounds(center, size);
        }

        public static Bounds GetBounds(params Renderer[] renderers)
        {
            Bounds[] bounds = new Bounds[renderers.Length];
            for (int i = 0; i < renderers.Length; i++)
                bounds[i] = renderers[i].bounds;
            return GetBounds(bounds);
        }

        public static Bounds GetBounds(params Collider[] colliders)
        {
            Bounds[] bounds = new Bounds[colliders.Length];
            for (int i = 0; i < colliders.Length; i++)
                bounds[i] = colliders[i].bounds;
            return GetBounds(bounds);
        }
    }

    [Serializable]
    public struct Point
    {
        /// <summary>
        /// X component of the point.
        /// </summary>
        public int x;

        /// <summary>
        /// Y component of the point.
        /// </summary>
        public int y;

        /// <summary>
        /// Constructs a new point with given x, y components.
        /// </summary>
        /// <param name="x">
        /// x component of the point.
        /// </param>
        /// <param name="y">
        /// y component of the point.
        /// </param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int this[int index]
        {
            get { return index == 0 ? x : y; }
            set
            {
                if (index == 0)
                    x = value;
                else
                    y = value;
            }
        }

        /// <summary>
        /// Shorthand for writing Point(1, 0).
        /// </summary>
        public static Point right { get { return new Point(1, 0); } }

        /// <summary>
        /// Shorthand for writing Point(-1, 0).
        /// </summary>
        public static Point left { get { return new Point(-1, 0); } }

        /// <summary>
        /// Shorthand for writing Point(0, -1).
        /// </summary>
        public static Point down { get { return new Point(0, -1); } }

        /// <summary>
        /// Shorthand for writing Point(0, 1).
        /// </summary>
        public static Point up { get { return new Point(0, 1); } }

        /// <summary>
        /// Shorthand for writing Point(1, 1).
        /// </summary>
        public static Point one { get { return new Point(1, 1); } }

        /// <summary>
        /// Shorthand for writing Point(0, 0).
        /// </summary>
        public static Point zero { get { return new Point(0, 0); } }

        /// <summary>
        /// Returns the highest point of the screen.
        /// </summary>
        public static Point Resolution { get { return new Point(UnityEngine.Screen.width, UnityEngine.Screen.height); } }


        /// <summary>
        /// Returns this point as a vector with a magnitude of 1 (Read Only).
        /// </summary>
        public Vector2 normalized
        {
            get
            {
                float m = magnitude;
                return new Vector2(x / m, y / m);
            }
        }

        /// <summary>
        /// Returns the squared length of this point (Read Only).
        /// </summary>
        public int sqrMagnitude { get { return x * x + y * y; } }

        /// <summary>
        /// Returns the length of this point (Read Only).
        /// </summary>
        public float magnitude { get { return Mathf.Sqrt(sqrMagnitude); } }

        /// <summary>
        /// Returns the unsigned angle in degrees between from and to.
        /// </summary>
        /// <param name="from">
        /// The vector from which the angular difference is measured.
        /// </param>
        /// <param name="to">
        /// The vector to which the angular difference is measured.
        /// </param>
        public static float Angle(Point from, Point to)
        {
            return Mathf.Acos(Dot(from, to) / (from.magnitude * to.magnitude));
        }

        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="from">
        /// The vector from which the angular difference is measured.
        /// </param>
        /// <param name="to">
        /// The vector to which the angular difference is measured.
        /// </param>
        public static float SignedAngle(Vector2 from, Vector2 to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        public static float Distance(Point a, Point b)
        {
            return Mathf.Sqrt((b - a).magnitude);
        }

        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        public static int Dot(Point lhs, Point rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        public static Point Max(Point lhs, Point rhs)
        {
            return new Point(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
        }

        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        public static Point Min(Point lhs, Point rhs)
        {
            return new Point(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
        }

        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        public static Point Scale(Point a, Point b)
        {
            return new Point(a.x * b.x, a.y * b.y);
        }

        /// <summary>
        /// 
        /// </summary>
        public static int SqrMagnitude(Point a)
        {
            return a.sqrMagnitude;
        }

        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other == (object)this)
                return true;
            if (!(other is Point))
                return false;

            Point o = (Point)other;
            return o.x == x && o.y == y;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            return HUtils.GetHashCode(x, y);
        }

        /// <summary>
        /// Multiplies every component of this vector by the same component of scale.
        /// </summary>
        public void Scale(Point scale)
        {
            x *= scale.x;
            y *= scale.y;
        }

        /// <summary>
        /// Set x and y components of an existing Vector2.
        /// </summary>
        public void Set(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        public string ToString(string format)
        {
            return "(" + x.ToString(format) + ", " + y.ToString(format) + ")";
        }

        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ")";
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        public static Point operator -(Point a)
        {
            return new Point(-a.x, -a.y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        public static Point operator *(Point a, int d)
        {
            return new Point(a.x * d, a.y * d);
        }

        public static Vector2 operator *(Point a, float d)
        {
            return new Vector2(a.x * d, a.y * d);
        }

        public static Point operator *(int d, Point a)
        {
            return new Point(a.x * d, a.y * d);
        }

        public static Vector2 operator *(float d, Point a)
        {
            return new Vector2(a.x * d, a.y * d);
        }

        public static Vector2 operator /(Point a, float d)
        {
            return new Vector2(a.x / d, a.y / d);
        }

        public static bool operator ==(Point lhs, Point rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y;
        }

        public static bool operator !=(Point lhs, Point rhs)
        {
            return lhs.x != rhs.x || lhs.y != rhs.y;
        }

        public static implicit operator Point(Vector3 v)
        {
            return new Point((int)v.x, (int)v.y);
        }

        public static implicit operator Vector3(Point v)
        {
            return new Vector3(v.x, v.y);
        }

        public static implicit operator Point(Vector2 v)
        {
            return new Point((int)v.x, (int)v.y);
        }

        public static implicit operator Vector2(Point v)
        {
            return new Vector2(v.x, v.y);
        }

        public static implicit operator Point(Resolution r)
        {
            return new Point(r.width, r.height);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public struct Line
    {
        public float m;
        public float n;

        public Line(float m, float n)
        {
            this.m = m;
            this.n = n;
        }

        public Line(float ax, float ay, float bx, float by)
        {
            m = ax != bx ? (by - ay) / (bx - ax) : 0F;
            n = -ax * m + ay;
        }

        public Line(Vector2 A, Vector2 B)
        {
            m = A.x != B.x ? (B.y - A.y) / (B.x - A.x) : 0F;
            n = -A.x * m + A.y;
        }

        public Vector2 Direction { get { return new Vector2(m, 1F).normalized; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool Intersects(Line other, out Vector2 point)
        {
            if (Intersects(other))
            {
                float x = (other.n - n) / (m - other.m);
                float y = m * x + n;

                point = new Vector2(x, y);

                return true;
            }

            point = Vector2.zero;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Intersects(Line other)
        {
            return m != other.m;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Angle Angle(Line other)
        {
            return Mathf.Acos(Mathf.Abs(Direction.x * other.Direction.x + Direction.y * other.Direction.y) / (Direction.magnitude * other.Direction.magnitude));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "y = " + m + "x + " + n;
        }

        public override bool Equals(object other)
        {
            if (!(other is Line))
                return false;

            Line line = (Line)other;
            return m.Equals(line.m) && n.Equals(line.n);
        }

        public override int GetHashCode()
        {
            return m.GetHashCode() ^ n.GetHashCode() << 2;
        }

        public static bool operator !=(Line lhs, Line rhs)
        {
            return lhs.m != rhs.m || lhs.n != rhs.n;
        }

        public static bool operator ==(Line lhs, Line rhs)
        {
            return lhs.m == rhs.m && lhs.n == rhs.n;
        }

        public static Angle Angle(Line a, Line b)
        {
            return a.Angle(b);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public struct Angle
    {
        [SerializeField]
        private float degrees;

        public Angle(float value = 0)
        {
            degrees = value % 360F;
        }

        public Angle(Vector2 a, Vector2 b)
        {
            degrees = Vector2.Angle(a, b);
        }

        public Angle(Line a, Line b)
        {
            degrees = Line.Angle(a, b);
        }

        /// <summary>
        /// Returns the <see cref="Angle"/> value in degrees clamped.
        /// </summary>
        public float Degrees { get { return degrees % 360F; } }

        /// <summary>
        /// Returns the <see cref="Angle"/> value in radians clamped.
        /// </summary>
        public float Radians { get { return Degrees * Mathf.Deg2Rad; } }

        /// <summary>
        /// Returns the sine of the <see cref="Angle"/>.
        /// </summary>
        public float Sin { get { return Mathf.Sin(Radians); } }

        /// <summary>
        /// Returns the cosine of the <see cref="Angle"/>.
        /// </summary>
        public float Cos { get { return Mathf.Cos(Radians); } }

        /// <summary>
        /// Returns the tangent of the <see cref="Angle"/>.
        /// </summary>
        public float Tan { get { return Mathf.Tan(Radians); } }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        public override string ToString()
        {
            return Degrees.ToString("F2") + "º";
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other == (object)this)
                return true;
            if (!(other is Angle))
                return false;

            Angle angle = (Angle)other;
            return Degrees.Equals(angle.Degrees);
        }

        public override int GetHashCode()
        {
            return degrees.GetHashCode();
        }

        public static implicit operator string(Angle angle) { return angle.ToString(); }
        public static implicit operator float(Angle angle) { return angle.Degrees; }
        public static implicit operator Angle(float angle) { return new Angle(angle); }
        public static bool operator ==(Angle lhs, Angle rhs) { return lhs.Degrees == rhs.Degrees; }
        public static bool operator !=(Angle lhs, Angle rhs) { return lhs.Degrees != rhs.Degrees; }
        public static Angle operator +(Angle lhs, Angle rhs) { return new Angle(lhs.Degrees + rhs.Degrees); }

        /// <summary>
        /// Returns a random <see cref="Angle"/> between 0º and 360º.
        /// </summary>
        public static Angle Random()
        {
            return HRandom.Float(360F);
        }

        /// <summary>
        /// Linearly interpolates between alpha and beta by t.
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="beta"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Angle Lerp(Angle alpha, Angle beta, float t)
        {
            return Mathf.Lerp(alpha.Degrees, beta.Degrees, t);
        }

        /// <summary>
        /// Returns the arc-cosine of f - the angle whose cosine is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Angle Acos(float f) { return Mathf.Acos(f) * Mathf.Rad2Deg; }

        /// <summary>
        /// Returns the arc-sine of f - the angle whose cosine is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Angle Asin(float f) { return Mathf.Asin(f) * Mathf.Rad2Deg; }

        /// <summary>
        /// Returns the arc-tangent of f - the angle whose cosine is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Angle Atan(float f) { return Mathf.Atan(f) * Mathf.Rad2Deg; }

        /// <summary>
        /// Returns the angle whose Tan is y/x.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Angle Atan2(float y, float x) { return Mathf.Atan2(y, x) * Mathf.Rad2Deg; }
    }
}