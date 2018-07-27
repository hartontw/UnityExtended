using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject
    {
        private static readonly object _lock = new object();
        private static T _instance;

        private ScriptableSingleton() { }

        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = Resources.Load<T>(typeof(T).Name);

                    return _instance;
                }
            }
        }

        public static T _ { get { return Instance; } }

        protected void Reset() { name = typeof(T).Name; }
    }
}