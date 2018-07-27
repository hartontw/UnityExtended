using System;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static int Add(this LayerMask self, params string[] layers)
        {
            int value = self.value;

            foreach (string layer in layers)
                value |= 1 << LayerMask.NameToLayer(layer);

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Contains(this LayerMask self, int layer)
        {
            return self.value == (self.value | (1 << layer));
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Contains(this LayerMask self, GameObject gameObject)
        {
            return self.value == (self.value | (1 << gameObject.layer));
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Contains(this LayerMask self, Component component)
        {
            return self.value == (self.value | (1 << component.gameObject.layer));
        }

        /// <summary>
        /// 
        /// </summary>
        public static int Reverse(this LayerMask self)
        {
            return -1 ^ self;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Bits(this LayerMask self)
        {
            return Convert.ToString(self, 2);
        }
    }
}