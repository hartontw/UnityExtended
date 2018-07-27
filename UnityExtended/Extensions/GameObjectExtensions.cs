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
        public static bool IsLayer(this GameObject self, string layerName)
        {
            return self.layer == LayerMask.NameToLayer(layerName);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsLayer(this GameObject self, params string[] layerNames)
        {
            foreach (string layerName in layerNames)
                if (self.layer == LayerMask.NameToLayer(layerName))
                    return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsLayer(this GameObject self, int layer)
        {
            return self.layer == layer;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsLayer(this GameObject self, params int[] layers)
        {
            foreach (int layer in layers)
                if (self.layer == layer)
                    return true;

            return false;
        }

        /// <summary>
        /// Adds a copy of 
        /// </summary>
        public static T AddCopy<T>(this GameObject go, T toAdd) where T : Component
        {
            return go.AddComponent<T>().GetCopyOf(toAdd) as T;
        }
    }
}