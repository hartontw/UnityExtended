using System;
using System.Reflection;
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
        public static bool IsLayer(this Component self, params int[] layers)
        {
            return self.gameObject.IsLayer(layers);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsLayer(this Component self, params string[] layers)
        {
            return self.gameObject.IsLayer(layers);
        }

        /// <summary>
        /// 
        /// </summary>
        public static T GetCopyOf<T>(this Component comp, T other) where T : Component
        {
            Type type = comp.GetType();
            if (type != other.GetType()) return null; // type mis-match
            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Default | BindingFlags.DeclaredOnly;
            PropertyInfo[] pinfos = type.GetProperties(flags);
            foreach (var pinfo in pinfos)
            {
                if (pinfo.CanWrite)
                {
                    try
                    {
                        pinfo.SetValue(comp, pinfo.GetValue(other, null), null);
                    }
                    catch
                    {
                        Debug.LogError("Error setting values caught with GetCopyOf");
                    }
                }
            }
            FieldInfo[] finfos = type.GetFields(flags);
            foreach (var finfo in finfos)
            {
                finfo.SetValue(comp, finfo.GetValue(other));
            }
            return comp as T;
        }
    }
}