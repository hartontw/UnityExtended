using UnityEngine;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class Singleton<T> where T : class, new()
    {
        private static readonly object _lock = new object();
        private static T _instance;

        private Singleton() { }

        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new T();

                    return _instance;
                }
            }
        }

        public static T _ { get { return Instance; } }
    }
}