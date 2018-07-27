using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool Contains(this Bounds self, Bounds other)
        {
            if (self.min.x > other.min.x) return false;
            if (self.min.y > other.min.y) return false;
            if (self.min.z > other.min.z) return false;
            if (self.max.x < other.max.x) return false;
            if (self.max.y < other.max.y) return false;
            if (self.max.z < other.max.z) return false;

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Bounds Intersection(this Bounds self, Bounds other)
        {
            if (self.Intersects(other))
            {
                Vector2 center = Vector2.zero;
                Vector2 size = Vector2.zero;

                if (self.min.x >= other.min.x && self.max.x <= other.max.x)
                {
                    center.x = self.center.x;
                    size.x = self.size.x;
                }
                else if (other.min.x >= self.min.x && other.max.x <= self.max.x)
                {
                    center.x = other.center.x;
                    size.x = other.size.x;
                }
                else if (self.min.x < other.min.x)
                {
                    size.x = Mathf.Abs(self.max.x - other.min.x);
                    center.x = self.max.x - (size.x) / 2F;
                }
                else
                {
                    size.x = Mathf.Abs(self.min.x - other.max.x);
                    center.x = self.min.x + (size.x) / 2F;
                }

                if (self.min.y >= other.min.y && self.max.y <= other.max.y)
                {
                    center.y = self.center.y;
                    size.y = self.size.y;
                }
                else if (other.min.y >= self.min.y && other.max.y <= self.max.y)
                {
                    center.y = other.center.y;
                    size.y = other.size.y;
                }
                else if (self.min.y < other.min.y)
                {
                    size.y = Mathf.Abs(self.max.y - other.min.y);
                    center.y = self.min.y - (size.y) / 2F;
                }
                else
                {
                    size.y = Mathf.Abs(self.min.y - other.max.y);
                    center.y = self.min.y + (size.y) / 2F;
                }

                return new Bounds(center, size);
            }
            return new Bounds();
        }

        /// <summary>
        /// 
        /// </summary>
        public static float Influence(this Bounds self, Bounds other)
        {
            Vector2 sizeA = self.Intersection(other).size;
            Vector2 sizeB = self.size;

            float areaA = sizeA.x * sizeA.y;
            float areaB = sizeB.x * sizeB.y;

            return areaA / areaB;
        }
    }
}